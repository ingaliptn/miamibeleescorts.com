using miamibeleescorts.com.Context;
using miamibeleescorts.com.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace miamibeleescorts.com.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public List<escorts> GetEscorts()
        {
            return _db.escorts.ToList();
        }
        public List<escorts> GetRandomEscorts(int number)
        {
            List<escorts> randomEscorts = new List<escorts>();
            int rowCount = _db.escorts.Count();

            Random rand = new Random();
            List<int> randomIndexes = new List<int>();

            // Generate 4 random indexes
            while (randomIndexes.Count < number)
            {
                int randomIndex = rand.Next(0, rowCount);
                if (!randomIndexes.Contains(randomIndex))
                {
                    randomIndexes.Add(randomIndex);
                }
            }

            // Retrieve escorts using the random indexes
            foreach (int index in randomIndexes)
            {
                escorts randomEscort = _db.escorts.Skip(index).FirstOrDefault();
                if (randomEscort != null)
                {
                    randomEscorts.Add(randomEscort);
                }
            }
            return randomEscorts;
        }
        public inform GetInfo(string pageLoc)
        {
            return _db.inform
                .Where(lp => lp.pageLocation == pageLoc)
                .FirstOrDefault();
        }
        public phoneNumber GetPhone()
        {
            return _db.phoneNumber.FirstOrDefault();
        }

        public IActionResult Index()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("home");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(8);
            return View(EscortsList);
        }

        [Route("about.php")]
        public IActionResult about()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("about");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            return View();
        }

        [Route("airport.php")]
        public IActionResult airport()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("airport");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("asian.php")]
        public IActionResult asian()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("asian");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "asian"));
        }

        [Route("busty.php")]
        public IActionResult busty()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("busty");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "busty"));
        }

        [Route("booking.php")]
        public IActionResult booking()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("booking");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            return View();
        }

        [Route("cheap.php")]
        public IActionResult cheap()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("cheap");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "cheap"));
        }

        [Route("contact.php")]
        public IActionResult contact()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("contact");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            return View();
        }

        [Route("ebony.php")]
        public IActionResult ebony()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("ebony");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "ebony"));
        }

        [Route("escorts.php")]
        public IActionResult escorts()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("escorts");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList);
        }

        [Route("gardens.php")]
        public IActionResult gardens()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("gardens");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("gfe.php")]
        public IActionResult gfe()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("gfe");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("hiring.php")]
        public IActionResult hiring()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("hiring");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            return View();
        }

        [Route("latina.php")]
        public IActionResult latina()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("latina");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "latina"));
        }

        [Route("lakes.php")]
        public IActionResult lakes()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("lakes");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("massage.php")]
        public IActionResult massage()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("massage");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "cheap"));
        }

        [Route("north.php")]
        public IActionResult north()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("north");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("russian.php")]
        public IActionResult russian()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("russian");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "russian"));
        }

        [Route("south-beach.php")]
        public IActionResult south_beach()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("south-beach");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetRandomEscorts(4);
            return View(EscortsList);
        }

        [Route("thankyou.php")]
        public IActionResult thankyou()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("thankyou");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            return View();
        }

        [Route("vip.php")]
        public IActionResult vip()
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;

            var pageInfo = GetInfo("vip");

            ViewBag.Title = pageInfo.titleText;
            ViewBag.Desc = pageInfo.descText;
            ViewBag.Canonical = pageInfo.canonicalText;
            ViewBag.Robots = pageInfo.robotsText;

            List<escorts> EscortsList = GetEscorts();
            return View(EscortsList.Where(r => r.rate1 == "vip"));
        }





        [Route("{rate2}.php")]
        public IActionResult profile(string rate2)
        {
            var phoneNum = GetPhone();

            ViewBag.PhoneShow = phoneNum.phoneShow;
            ViewBag.PhoneCall = phoneNum.phoneCall;


            escorts model = new escorts();

            var escort = _db.escorts.FirstOrDefault(e => e.rate2 == rate2);
            if (escort != null)
            {
                model.escortname = escort.escortname;
                model.age = escort.age;
                model.bra = escort.bra;
                model.dress = escort.dress;
                model.height = escort.height;
                model.weight = escort.weight;
                model.hair = escort.hair;
                model.availability = escort.availability;
                model.language = escort.language;
                model.nationality = escort.nationality;
                model.eye = escort.eye;
                model.rate2 = escort.rate2;
                model.rate1 = escort.rate1;
                model.file_name1 = escort.file_name1;
                model.file_name2 = escort.file_name2;
                model.file_name3 = escort.file_name3;
                model.file_name4 = escort.file_name4;
                model.file_name5 = escort.file_name5;
                model.file_name6 = escort.file_name6;
                model.file_name7 = escort.file_name7;
                model.file_name8 = escort.file_name8;
                model.file_name9 = escort.file_name9;
                model.file_name10 = escort.file_name10;
                model.file_name11 = escort.file_name11;
                model.description = escort.description;
            }
            //$myTitle="Busty Escort Girl $girlname At Miami Bele Escorts";
            //$myDesc="$girlname is available and waiting for you at Miami Bele Escorts. Do not look for more and book her right now!";

            ViewBag.Desc = $"{model.escortname} is available and waiting for you at Miami Bele Escorts. Do not look for more and book her right now!";
            ViewBag.Title = $"{model.nationality} Escort Girl {model.escortname} At Miami Bele Escorts";
            ViewBag.Canonical = $"http://www.miamibeleescorts.com/{model.rate2}.php";
            ViewBag.Robots = "index, follow";

            return View(model);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
