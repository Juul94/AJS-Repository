using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySystem
{
    public class User
    {
        #region Fields - Klassens indkapslede egenskaber
            private string username;
            private string firstname;
            private string lastname;
            private int role;
        #endregion

        #region Construntors - Klassens konstruktør (er)
            public User () 
            {

            }

            /// <summary>
            /// Konstrurerer en User og sætter værdier til de fire fields
            /// </summary>
            /// <param name="username">Skriv brugerens brugernavn</param>
            /// <param name="firstname">Skriv brugerens fornavn</param>
            /// <param name="lastname">Skriv brugerens efternavn</param>
            /// <param name="role">Skriv et tal svarende brugerens rolle</param>
            
            public User(string username, string firstname, string lastname, int role)
	        {
		        // Her overføres værdierne til de fire fields
                this.username = username;
                this.firstname = firstname;
                this.lastname = lastname;
                this.role = role;
	        }
        #endregion

        #region Proporties - Klassens offentlige adgang til de indkapslede fields

        public string Username  { get { return this.username; }  set { this.username = value; } }
        public string Firstname { get { return this.firstname; } set { this.firstname = value; } }
        public string Lastname  { get { return this.lastname; }  set { this.lastname = value; } }
        public int Role         { get { return this.role; }      set { this.role = value; } }

        // 'get' læser fieldets værdi
        // 'set' skriver til fieldet

        #endregion

        #region Methods - Klassens offentige metoder
        public static bool IsUser()
        {
            bool result = false;

            // Du bliver nødt til at anvende HttpContext.Current foran dine sessions, når du programmerer dine klassefiler
            if (HttpContext.Current.Session["user"] != null)
            {
                result = true;
            }

            // Metoden mangler en retur værdi af typen bool, som vi efterfølgende indsætter
            // Public gør metoden tilgængelig fra websiden og static gør, at vi ikke behøver at oprette en 
            // instans af klassen for at anvende metoden (mere om det senere)

            return result;
        }

        public static void CreateSession()
        {
            if (HttpContext.Current.Session["user"] == null)
            {
                HttpContext.Current.Session.Add("user", "noname");
            }
        }

        public static void RemoveSession()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                HttpContext.Current.Session.Remove("user");
            }
        }
        #endregion
    }
}