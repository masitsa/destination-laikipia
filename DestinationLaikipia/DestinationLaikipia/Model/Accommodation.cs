using System;
using System.Collections.Generic;
using System.Text;

namespace DestinationLaikipia.Model
{
    public class Accommodation
    {
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string HotelRatings { get; set; }
        public string HotelImageUrl { get; set; }

        public List<Accommodation> GetAccommodations()
        {
            List<Accommodation> accommodations = new List<Accommodation>()
            {
                new Accommodation(){
                HotelName ="Le Rustique",
                HotelDescription="Le Rustique provides a garden and free Wifi. Featuring a terrace.",
                HotelImageUrl="Le_Rustique.jpg",
                HotelRatings="3.5"
                },
                new Accommodation(){
                HotelName ="Fairmont Mount Kenya Safari Club",
                HotelDescription="With magnificent views of majestic Mount Kenya, the Fairmont Mount Kenya Safari Club Resort's 120 luxuriously appointed hotel rooms, set in over 100 acres of landscaped gardens, offer a unique blend of comfort, relaxation and adventure. Its no wonder this Nanyuki resort emerged a winner in the 2013 Travellers Choice Awards and that Travel & Leisure Magazine often positions it in the 'World's Top 50' List. ",
                HotelImageUrl="fairmont.jpg",
                HotelRatings="4.5"
                },
                new Accommodation(){
                HotelName ="Penguin Hotel Nanyuki",
                HotelDescription="Those who wish to spend time relaxing at the Mount Kenya resort hotel, there are many Nanyuki recreational activities available: horseback riding, golf, croquet, a bowling green, table tennis, swimming, an animal orphanage and much more. To be able to relax and appreciate the superb setting,",
                HotelImageUrl="penguin.jpg",
                HotelRatings="4.1"
                },
                new Accommodation(){
                HotelName ="Falcon Heights Hotel",
                HotelDescription="Falcon Heights Hotel is a niche boutique hotel that nestles in lush landscaped gardens in Nanyuki. The hotel has 16 luxurious rooms and an executive 2 bedroom cottage. Features include spacious room and bathroom, LCD flat screen, Ip phone, wi-fi, hair dryer and shaving unit, plush lounge chairs with complementary coffee and tea service. It has an ultra modern conference facility that can host up to 50 guests indoor and 500 outdoor. At all times the guests enjoy signature mouthwatering cuisine and warm Kenyan hospitality.",
                HotelImageUrl="falcon.gif",
                HotelRatings="3.5"
                }
            };
            return accommodations;
        }
    }
}
