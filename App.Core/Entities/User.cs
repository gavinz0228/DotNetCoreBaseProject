namespace App.Core.Entities{
    public class User: BaseEntity{
        public string UserName {get;set;}
        public string Password {get;set;}
        public string Email {get;set;}
    }
}