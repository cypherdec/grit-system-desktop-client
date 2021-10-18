using GritLibrary.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoGritLogin.Services
{
    public interface IDAO 
    {
        AutoCompleteStringCollection Auto();
        bool CheckIfClientIsRegistered(ClientModel client);
        CoachModel CoachLogin(CoachModel coach);
        bool DeleteClient(ClientModel client);
        bool DeleteCoach(CoachModel coach);
        bool DeleteFood(FoodModel food);
        List<ClientModel> GetAllClients();
        List<CoachModel> GetAllCoaches();
        List<FoodModel> GetAllFoods();
        List<FoodModel> GetAllOfAType(string type);
        ClientModel GetClientDataFromSearch(ClientModel client);
        List<ProgressModel> GetClientProgresses(int id, int pastRecords);
        FoodModel GetFoodAmount(string name);
        ProgressModel GetProgressDataFromClientID(int id);
        bool SaveFood(FoodModel food);
        bool SaveNewClientAndProgressInfo(ClientModel client, ProgressModel progress);
        bool SaveNewCoach(CoachModel coach);
        bool UpdateClient(ClientModel client);
        bool UpdateClientProgress(ProgressModel progress);
        bool UpdateCoachLogin(CoachModel coach);
        bool UpdateFood(FoodModel food);
    }
}