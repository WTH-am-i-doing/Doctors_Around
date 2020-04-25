using Doctors_Around.Core;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors_Around.Data
{
    public class IFirebaseLoginHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://doctors-around.firebaseio.com/");

            public async Task<List<User>> GetAllPersons()
            { 
                return (await firebase.Child("Users")
                  .OnceAsync<User>()).Select(item => new User
                  {
                      Symptoms = item.Object.Symptoms,
                      Country = item.Object.Country,
                        accountType= item.Object.accountType,
                        City=item.Object.City,
                        Email=item.Object.Email,
                        Full_Adress = item.Object.Full_Adress,
                        Full_Name = item.Object.Full_Name,
                        Medicins = item.Object.Medicins,
                        Password = item.Object.Password,
                        Phone_number = item.Object.Phone_number,
                        PreviousIllnesses = item.Object.PreviousIllnesses,
                        RequestedCases = item.Object.RequestedCases,
                        Specialty = item.Object.Specialty
                  }).ToList();
            }

            public async Task SignUp(User user)
            {

                await firebase
                  .Child("Users")
                  .PostAsync(user);
            }

            public async Task<User> GetUser(string email)
            {
                var allPersons = await GetAllPersons();
                await firebase
                  .Child("Users")
                  .OnceAsync<User>();
                return allPersons.Where(a => a.Email == email).FirstOrDefault();
            }

            public async Task UpdateUser(string email, User updatedUser)
            {
                var toUpdatePerson = (await firebase
                  .Child("Users")
                  .OnceAsync<User>()).Where(a => a.Object.Email == email).FirstOrDefault();

                await firebase
                  .Child("Users")
                  .Child(toUpdatePerson.Key)
                  .PutAsync(updatedUser);
            }

            public async Task DeleteUser(string email)
            {
                var toDeletePerson = (await firebase
                  .Child("Users")
                  .OnceAsync<User>()).Where(a => a.Object.Email == email).FirstOrDefault();
                await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

            }
        }

    }


