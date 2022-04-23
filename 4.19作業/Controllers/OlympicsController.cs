using _4._19作業.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4._19作業.Controllers
{
    public class OlympicsController : Controller
    {
        private static List<Olympics> _olympics = new List<Olympics>()   //第三題
        {
            new Olympics(){ Medal = "金牌" , Name = "郭婞淳" , Sport = "舉重" , PrizeMoney = 20000000},
            new Olympics(){ Medal = "金牌" , Name = "李洋、王齊麟" , Sport = "羽球" , PrizeMoney = 20000000},
            new Olympics(){ Medal = "銀牌" , Name = "楊勇緯" , Sport = "柔道" , PrizeMoney = 7000000},
            new Olympics(){ Medal = "銀牌" , Name = "鄧宇成、湯智鈞" , Sport = "射箭" , PrizeMoney = 7000000},
            new Olympics(){ Medal = "銀牌" , Name = "李智凱" , Sport = "體操 " , PrizeMoney = 7000000},
            new Olympics(){ Medal = "銀牌" , Name = "戴資穎" , Sport = "羽球" , PrizeMoney = 7000000},
            new Olympics(){ Medal = "銅牌" , Name = "羅嘉翎" , Sport = "跆拳道" , PrizeMoney = 5000000},
            new Olympics(){ Medal = "銅牌" , Name = "林昀儒、鄭怡靜" , Sport = "桌球" , PrizeMoney = 5000000},
            new Olympics(){ Medal = "銅牌" , Name = "陳玟卉" , Sport = "舉重" , PrizeMoney = 5000000},
            new Olympics(){ Medal = "銅牌" , Name = "潘政琮" , Sport = "高爾夫" , PrizeMoney = 5000000},
            new Olympics(){ Medal = "銅牌" , Name = "黃筱雯" , Sport = "拳擊" , PrizeMoney = 5000000},
            new Olympics(){ Medal = "銅牌" , Name = "文姿云" , Sport = "空手道" , PrizeMoney = 5000000},
        };

        public ActionResult LinqHomework()
        {
            var goldmedal = _olympics   //第四題
                .Where(x => x.Medal == "金牌").ToList();
            var badminton = _olympics   //第五題
                .Where(x => x.Sport == "羽球").ToList();
            var bonus = _olympics   //第六題
                .OrderBy(x => x.PrizeMoney).ToList();
            var TOPbonus = _olympics   //第七題
                .Max(x => x.PrizeMoney);
            var allbonus = _olympics   //第八題
                .Sum(x => x.PrizeMoney);


            var badmintonMoney = _olympics   //挑戰題1
                .Where(x => x.Sport =="羽球")
                .Sum(x => x.PrizeMoney);
            var silvermedal = _olympics   //挑戰題2
                .Where(x => x.Medal == "銀牌")
                .Sum(x => x.PrizeMoney);
            return RedirectToAction("Olympics","Index");
        }

        // GET: OlympicsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OlympicsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OlympicsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OlympicsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OlympicsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OlympicsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OlympicsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OlympicsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
