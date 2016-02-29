using DemoApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DotNetController : Controller
    {
        // GET: DotNet
        public JToken Index()
        {
            voyagePlan voyage = new voyagePlan();
            voyage.vessel = "FA";
            voyage.name = "PACIFIC FAITHFUL";
            voyage.nationality = "LIBERIA";
            voyage.voyage = "0009";
            voyage.leg = "N";
            voyage.line = "SWI";
            voyage.consolidationline = "";
            voyage.consortsailingno = "9";
            voyage.master = "VP 12 DECEMEBER HGH";
            voyage.trade = "USW";
            voyage.service = "USW";
            voyage.weight = "KG";
            voyage.statisticsPeriod = "31 MARCH 2007";
            voyage.currency = "2";
            voyage.mot = "S";
            voyage.measure = "M3";
            voyage.temp = "C";
            voyage.vesselPlan = "";
            voyage.publish = "";
            voyage.loadingDateBasis = "";
            voyage.user = "";
            portDetails portdetail = new portDetails();
            portdetail.port = "AUBNE";
            portdetail.seq = 1;
            portdetail.lcc = "BNS";
            voyage.portDetails = portdetail;
            List<currency> currencyList = new List<currency>();
            currency cu = new currency();
            cu.Currency = "AUD";
            cu.ExchangeRate = 1.2694000;
            currencyList.Add(cu);

            currency cu1 = new currency();
            cu1.Currency = "CAD";
            cu1.ExchangeRate = 1.1739500;
            currencyList.Add(cu1);
            currency cu2 = new currency();
            cu2.Currency = "EUR";
            cu2.ExchangeRate = 0.7723500;
            currencyList.Add(cu2);
            currency cu3 = new currency();
            cu3.Currency = "FJD";
            cu3.ExchangeRate = 1.1667500;
            currencyList.Add(cu3);
            currency cu4 = new currency();
            cu4.Currency = "GBP";
            cu4.ExchangeRate = 0.55072000;
            currencyList.Add(cu4);
            currency cu5 = new currency();
            cu5.Currency = "0.55072000";
            cu5.ExchangeRate = 7.80758900;
            currencyList.Add(cu5);
            portdetail.currency = currencyList;

            List<voyagePlan> voyagelist = new List<voyagePlan>();
            voyagelist.Add(voyage);
            voyagePlan v1 = new voyagePlan();
            v1.name = "ARABIAN";
            v1.nationality = "INDIA";
            v1.voyage = "0019";
            v1.leg = "Y";
            v1.vessel = "F4";
            v1.currency = "4";
            voyagelist.Add(v1);
            voyagePlan v2 = new voyagePlan();
            v2.name = "ARABIAN";
            v2.nationality = "INDIA";
            v2.voyage = "0912";
            v2.leg = "N";
            v2.vessel = "Harvey Spirit";
            v2.currency = "3";
            voyagelist.Add(v2);
            voyagePlan v3 = new voyagePlan();
            v3.name = "ARABIAN";
            v3.nationality = "INDIA";
            v3.voyage = "0312";
            v3.leg = "Y";
            v3.vessel = "GreyStone";
            v3.currency = "1";
            voyagelist.Add(v3);
            voyagePlan v4 = new voyagePlan();
            v4.name = "ARABIAN";
            v4.nationality = "INDIA";
            v4.voyage = "0122";
            v4.leg = "Y";
            v4.vessel = "Innovator";
            v4.currency = "2";
            voyagelist.Add(v4);
            voyagePlan v5 = new voyagePlan();
            v5.name = "ARABIAN";
            v5.nationality = "INDIA";
            v5.voyage = "0312";
            v5.leg = "N";
            v5.vessel = "Sandstorm";
            v5.currency = "2";
            voyagelist.Add(v5);
            return JToken.Parse(JsonConvert.SerializeObject(voyagelist));
        }

        public ActionResult DemoPage(string Vessel, string Voyage, string Currency,string filter)
        {

            List<voyagePlan> vlist = new List<voyagePlan>();
            ViewBag.filter = filter;
            if (!string.IsNullOrEmpty(Vessel) || !string.IsNullOrEmpty(Voyage)|| !string.IsNullOrEmpty(Currency) || !string.IsNullOrEmpty(filter))
            {
                voyagePlan voyage = new voyagePlan();
                voyage.vessel = "FA";
                voyage.name = "PACIFIC FAITHFUL";
                voyage.nationality = "LIBERIA";
                voyage.voyage = "0009";
                voyage.leg = "N";
                voyage.line = "SWI";
                voyage.consolidationline = "";
                voyage.consortsailingno = "9";
                voyage.master = "VP 12 DECEMEBER HGH";
                voyage.trade = "USW";
                voyage.service = "USW";
                voyage.weight = "KG";
                voyage.statisticsPeriod = "31 MARCH 2007";
                voyage.currency = "USD";
                voyage.mot = "S";
                voyage.measure = "M3";
                voyage.temp = "C";
                voyage.vesselPlan = "";
                voyage.publish = "";
                voyage.loadingDateBasis = "";
                voyage.user = "";
                portDetails portdetail = new portDetails();
                portdetail.port = "AUBNE";
                portdetail.seq = 1;
                portdetail.lcc = "BNS";
                voyage.portDetails = portdetail;
                List<currency> currencyList = new List<currency>();
                currency cu = new currency();
                cu.Currency = "AUD";
                cu.ExchangeRate = 1.2694000;
                currencyList.Add(cu);

                currency cu1 = new currency();
                cu1.Currency = "CAD";
                cu1.ExchangeRate = 1.1739500;
                currencyList.Add(cu1);
                currency cu2 = new currency();
                cu2.Currency = "EUR";
                cu2.ExchangeRate = 0.7723500;
                currencyList.Add(cu2);
                currency cu3 = new currency();
                cu3.Currency = "FJD";
                cu3.ExchangeRate = 1.1667500;
                currencyList.Add(cu3);
                currency cu4 = new currency();
                cu4.Currency = "GBP";
                cu4.ExchangeRate = 0.55072000;
                currencyList.Add(cu4);
                currency cu5 = new currency();
                cu5.Currency = "0.55072000";
                cu5.ExchangeRate = 7.80758900;
                currencyList.Add(cu5);
                portdetail.currency = currencyList;
                vlist.Add(voyage);
                voyagePlan v1 = new voyagePlan();
                v1.name = "ARABIAN";
                v1.nationality = "INDIA";
                v1.voyage = "0281";
                v1.leg = "Y";
                v1.vessel = "Harvey Explorer";
                v1.currency = "AUD";
                vlist.Add(v1);
                voyagePlan v2 = new voyagePlan();
                v2.name = "ARABIAN";
                v2.nationality = "INDIA";
                v2.voyage = "0912";
                v2.leg = "N";
                v2.vessel = "Harvey Spirit";
                v2.currency = "SGD";
                vlist.Add(v2);
                voyagePlan v3 = new voyagePlan();
                v3.name = "ARABIAN";
                v3.nationality = "INDIA";
                v3.voyage = "0312";
                v3.leg = "Y";
                v3.vessel = "GreyStone";
                v3.currency = "FJD";
                vlist.Add(v3);
                voyagePlan v4 = new voyagePlan();
                v4.name = "ARABIAN";
                v4.nationality = "INDIA";
                v4.voyage = "0122";
                v4.leg = "Y";
                v4.vessel = "Innovator";
                v4.currency = "EUR";
                vlist.Add(v4);
                voyagePlan v5 = new voyagePlan();
                v5.name = "ARABIAN";
                v5.nationality = "INDIA";
                v5.voyage = "0312";
                v5.leg = "N";
                v5.vessel = "Sandstorm";
                v5.currency = "AUD";
                vlist.Add(v5);
            }
            if (!string.IsNullOrEmpty(filter))
            {
                if(filter == "vessel") {
                    ViewBag.searchresults = vlist.OrderBy(x => x.vessel).ToList();
                }
                else{
                    ViewBag.searchresults = vlist.OrderBy(x => x.voyage).ToList();
                }
                
            }
            else
            {
                ViewBag.searchresults = vlist;
            }

            return View();
        }

        [HttpGet]
        public ActionResult RegistrationPage(string value,string edit)
        {
            ViewBag.edit = edit;
            voyagePlan voyage = new voyagePlan();
            voyage.vessel = "FA";
            voyage.name = "PACIFIC FAITHFUL";
            voyage.nationality = "LIBERIA";
            voyage.voyage = "0009";
            voyage.leg = "N";
            voyage.line = "SWI";
            voyage.consolidationline = "";
            voyage.consortsailingno = "9";
            voyage.master = "VP 12 DECEMEBER HGH";
            voyage.trade = "USW";
            voyage.service = "USW";
            voyage.weight = "KG";
            voyage.kind = value;
            voyage.statisticsPeriod = "31 MARCH 2007";
            voyage.currency = "USD";
            voyage.mot = "S";
            voyage.measure = "M3";
            voyage.temp = "C";
            voyage.vesselPlan = "";
            voyage.publish = "";
            voyage.loadingDateBasis = "";
            voyage.user = "";
            portDetails portdetail = new portDetails();
            portdetail.port = "AUBNE";
            portdetail.seq = 1;
            portdetail.lcc = "BNS";
            voyage.portDetails = portdetail;
            List<currency> currencyList = new List<currency>();
            currency cu = new currency();
            cu.Currency = "AUD";
            cu.ExchangeRate = 1.2694000;
            currencyList.Add(cu);

            currency cu1 = new currency();
            cu1.Currency = "CAD";
            cu1.ExchangeRate = 1.1739500;
            currencyList.Add(cu1);
            currency cu2 = new currency();
            cu2.Currency = "EUR";
            cu2.ExchangeRate = 0.7723500;
            currencyList.Add(cu2);
            currency cu3 = new currency();
            cu3.Currency = "FJD";
            cu3.ExchangeRate = 1.1667500;
            currencyList.Add(cu3);
            currency cu4 = new currency();
            cu4.Currency = "GBP";
            cu4.ExchangeRate = 0.55072000;
            currencyList.Add(cu4);
            currency cu5 = new currency();
            cu5.Currency = "0.55072000";
            cu5.ExchangeRate = 7.80758900;
            currencyList.Add(cu5);
            portdetail.currency = currencyList;
            List<voyagePlan> vlist = new List<voyagePlan>();
            voyagePlan v1 = new voyagePlan();
            v1.name = "ARABIAN";
            v1.nationality = "INDIA";
            v1.voyage = "0281";
            v1.leg = "Y";
            v1.vessel = "Harvey Explorer";
            v1.currency = "CAD";
            vlist.Add(v1);
            voyagePlan v2 = new voyagePlan();
            v2.name = "ARABIAN";
            v2.nationality = "INDIA";
            v2.voyage = "0912";
            v2.leg = "N";
            v2.vessel = "Harvey Spirit";
            v2.currency = "FJD";
            vlist.Add(v2);
            voyagePlan v3 = new voyagePlan();
            v3.name = "ARABIAN";
            v3.nationality = "INDIA";
            v3.voyage = "0312";
            v3.leg = "Y";
            v3.vessel = "GreyStone";
            v3.currency = "AUD";
            vlist.Add(v3);
            voyagePlan v4 = new voyagePlan();
            v4.name = "ARABIAN";
            v4.nationality = "INDIA";
            v4.voyage = "0122";
            v4.leg = "Y";
            v4.vessel = "Innovator";
            v4.currency = "USD";
            vlist.Add(v4);
            voyagePlan v5 = new voyagePlan();
            v5.name = "ARABIAN";
            v5.nationality = "INDIA";
            v5.voyage = "0312";
            v5.leg = "N";
            v5.vessel = "Sandstorm";
            v5.currency = "SGD";
            vlist.Add(v5);
            ViewBag.getlist = vlist;
            ViewBag.getobject = voyage;
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationPage(bool popup,string edit)
        {
            ViewBag.popup = popup;
            ViewBag.edit = edit;
            voyagePlan voyage = new voyagePlan();
            voyage.vessel = "FA";
            voyage.name = "PACIFIC FAITHFUL";
            voyage.nationality = "LIBERIA";
            voyage.voyage = "0009";
            voyage.leg = "N";
            voyage.line = "SWI";
            voyage.consolidationline = "";
            voyage.consortsailingno = "9";
            voyage.master = "VP 12 DECEMEBER HGH";
            voyage.trade = "USW";
            voyage.service = "USW";
            voyage.weight = "KG";
            voyage.kind = "";
            voyage.statisticsPeriod = "31 MARCH 2007";
            voyage.currency = "USD";
            voyage.mot = "S";
            voyage.measure = "M3";
            voyage.temp = "C";
            voyage.vesselPlan = "";
            voyage.publish = "";
            voyage.loadingDateBasis = "";
            voyage.user = "";
            portDetails portdetail = new portDetails();
            portdetail.port = "AUBNE";
            portdetail.seq = 1;
            portdetail.lcc = "BNS";
            voyage.portDetails = portdetail;
            List<currency> currencyList = new List<currency>();
            currency cu = new currency();
            cu.Currency = "AUD";
            cu.ExchangeRate = 1.2694000;
            currencyList.Add(cu);

            currency cu1 = new currency();
            cu1.Currency = "CAD";
            cu1.ExchangeRate = 1.1739500;
            currencyList.Add(cu1);
            currency cu2 = new currency();
            cu2.Currency = "EUR";
            cu2.ExchangeRate = 0.7723500;
            currencyList.Add(cu2);
            currency cu3 = new currency();
            cu3.Currency = "FJD";
            cu3.ExchangeRate = 1.1667500;
            currencyList.Add(cu3);
            currency cu4 = new currency();
            cu4.Currency = "GBP";
            cu4.ExchangeRate = 0.55072000;
            currencyList.Add(cu4);
            currency cu5 = new currency();
            cu5.Currency = "0.55072000";
            cu5.ExchangeRate = 7.80758900;
            currencyList.Add(cu5);
            portdetail.currency = currencyList;
            List<voyagePlan> vlist = new List<voyagePlan>();
            voyagePlan v1 = new voyagePlan();
            v1.name = "ARABIAN";
            v1.nationality = "INDIA";
            v1.voyage = "0281";
            v1.leg = "Y";
            v1.vessel = "Harvey Explorer";
            v1.currency = "CAD";
            vlist.Add(v1);
            voyagePlan v2 = new voyagePlan();
            v2.name = "ARABIAN";
            v2.nationality = "INDIA";
            v2.voyage = "0912";
            v2.leg = "N";
            v2.vessel = "Harvey Spirit";
            v2.currency = "FJD";
            vlist.Add(v2);
            voyagePlan v3 = new voyagePlan();
            v3.name = "ARABIAN";
            v3.nationality = "INDIA";
            v3.voyage = "0312";
            v3.leg = "Y";
            v3.vessel = "GreyStone";
            v3.currency = "AUD";
            vlist.Add(v3);
            voyagePlan v4 = new voyagePlan();
            v4.name = "ARABIAN";
            v4.nationality = "INDIA";
            v4.voyage = "0122";
            v4.leg = "Y";
            v4.vessel = "Innovator";
            v4.currency = "USD";
            vlist.Add(v4);
            voyagePlan v5 = new voyagePlan();
            v5.name = "ARABIAN";
            v5.nationality = "INDIA";
            v5.voyage = "0312";
            v5.leg = "N";
            v5.vessel = "Sandstorm";
            v5.currency = "SGD";
            vlist.Add(v5);
            ViewBag.getlist = vlist;
            ViewBag.getobject = voyage;
            return View();
        }
        public ActionResult CurrencyPage()
        {
            return View();
        }

        public ActionResult ClausePage()
        {
            return View();
        }
    }
}