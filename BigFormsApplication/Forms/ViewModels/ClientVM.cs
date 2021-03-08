using Model;

namespace BigFormsApplication.Forms.ViewModels
{
    public class ClientVM
    {
        public Client Client { get; set; }
        public string LineInListBox
        {
            get
            {
                return Client.ClientNumber + " - " + Client.FirstName;
            }
        }
    }
}
