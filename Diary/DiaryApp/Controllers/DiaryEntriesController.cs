using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if(obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if(ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);  //새로운 Diary Entriy를 데이터베이스에 추가
                _db.SaveChanges();          // 변경점을 데이터베이스에 저장
                return RedirectToAction("Index", "Home");
            }
            return View(obj); // 해당페이지 리로딩
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if(diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if(ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj); // 업데이트로 간단히 되는듯
                _db.SaveChanges();
                return Redirect("Index");
            }

            //if (obj != null && obj.Title.Length < 3)
            //{
            //    ModelState.AddModelError("Title", "Title is too short");
            //}

            //var entry = _db.DiaryEntries.FirstOrDefault(e => e.Id == obj.Id);
            //if(entry == null)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    entry.Title = obj.Title;
            //    entry.Content = obj.Content;
            //    entry.CreatedDate = obj.CreatedDate;
            //    _db.SaveChanges();        
                
            //    return RedirectToAction("Index", "Home");
            //}

            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // 여기서 모든걸 처리하는게 아니라 서치만
            //if(id == null || id == 0)
            //{
            //    return NotFound();
            //}

            var entry = _db.DiaryEntries.Find(id);

            if (entry == null)
            {
                return NotFound();
            }
            //_db.DiaryEntries.Remove(entry);
            //_db.SaveChanges();
            return View(entry);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var entry = _db.DiaryEntries.Find(id);

            _db.DiaryEntries.Remove(entry);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
