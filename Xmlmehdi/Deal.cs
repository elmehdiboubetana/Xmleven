using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xmlmehdi
{
    class Deal
    {
        public string id;
        public string city;
        public string category;
        public string title;
        public string description;
        public double price;
        public double discount;
        public DateTime StarTime;
        public DateTime EndTime;
        public string MarchantName;
        public string MarchantAdresse;
        public string img;
        public string LinkView;
        public string LinkAchat;
        public string MarchanPhone;
        public Deal() { }

        public Deal(string id, string city, string category, string title, string discription, double price,
                    double discount, DateTime startime, DateTime endtime, string marchantname,
                    string marchantadresse, string img, string linkview, string linkachat,string marchanphone)
        {
            this.id = id;
            this.city = city;
            this.category = category;
            this.title = title;
            this.description = discription;
            this.price = price;
            this.discount = discount;
            this.StarTime = startime;
            this.EndTime = endtime;
            this.MarchantName = marchantname;
            this.MarchantAdresse = marchantadresse;
            this.img = img;
            this.LinkView = linkview;
            this.LinkAchat = linkachat;
            this.MarchanPhone = marchanphone;
        }



    }
}
