using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
    public class ClientExtendOperation
    {
        public void ClientExtend(int ID, int passtype, string passvalue)  //ID klienta, , ID wejściówki, Nazwa wejściówki
        {
            var db = new DbModel();
            var inquiry = (from client in db.Clients where client.Id.Equals(ID) select client).FirstOrDefault();    //inquiry to inaczej klient

            if (inquiry != null)  
            {                                                                      //jeśli wejście jest jednorazowe, ustaw date ważności karnetu na dzisiaj
                if (passvalue == "Jednorazowe" && passtype == inquiry.PassType)   //problematyczne, jak rozpoznać karnet jeśli ktoś go zmieni w bazie danych?
                {                                                                 //combobox w poprzedniej klasie jest do tego przygotowany, wypełnia się aktualnymi danymi
                    inquiry.ExpDate = DateTime.Now;                              //ale co jeśli ktoś usunie karnet razem z ID i doda inny? jak można się do tego statycznie przygotować?
                }                                                                           
                else if (passtype != inquiry.PassType && inquiry.ExpDate > DateTime.Now && inquiry.PassType != 5)  //nie można uaktualnić, jeśli karnety i ich ceny były różne i karnet się jescze nie skończył
                {                                                                                                 
                    Error error = new Error("Nie można przedłużyć tego karnetu ponieważ jest inny niż dotychczas. Poczekaj aż okres ważności dobiegnie końca!"); error.Show();
                    return;
                }                                          
                else if (passvalue == "Jednorazowe" && passtype != inquiry.PassType && inquiry.ExpDate > DateTime.Now) 
                {                                                                                                       
                    Error error = new Error("Nie można wykupić wejść jednorazowych gdy karnet jest aktywny!"); error.Show();
                    return;
                }
                else if (inquiry.ExpDate < DateTime.Now)
                {
                    inquiry.ExpDate = DateTime.Now.AddDays(30); //jeśli karnet jest aktywny w momencie zakupu to dodajemy do niego daty ważności 30 dni 
                }
                else if (inquiry.ExpDate >= DateTime.Now)
                {
                    inquiry.ExpDate = inquiry.ExpDate.AddDays(30); //jeśli karnet jest nieaktywny od przeszłego czasu, dodajemy 30 dni od dzisiejszej daty
                }

                inquiry.PassType = passtype;
                db.Clients.Update(inquiry);
                db.SaveChanges();
            }
        }
    }
}
