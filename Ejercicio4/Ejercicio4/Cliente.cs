using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cliente
    {
        private int personid;

        public int PersonId
        {
            get { return this.personid; }
            set { this.personid = value; }
        }
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private string lastname;

        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        private string currentrole;

        public string CurrentRole
        {
            get { return this.currentrole; }
            set { this.currentrole = value; }
        }
        private string country;

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        private string industry;

        public string Industry
        {
            get { return this.industry; }
            set { this.industry = value; }
        }


        private double numberOfRecommendations;

        public double NumberOfRecommendations
        {
            get { return this.numberOfRecommendations; }
            set { this.numberOfRecommendations = value; }
        }

        private double numberOfConnections;

        public double NumberOfConnections
        {
            get { return this.numberOfConnections; }
            set { this.numberOfConnections = value; }
        }

        private double indiceClientePotencial;

        public double IndiceClientePotencial
        {
            get { return this.indiceClientePotencial; }
            set { this.indiceClientePotencial = value; }
        }

    }
}
