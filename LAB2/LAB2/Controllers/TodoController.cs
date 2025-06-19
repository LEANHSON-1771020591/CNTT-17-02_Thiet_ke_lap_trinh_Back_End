using Microsoft.AspNetCore.Mvc;
using LAB2.Models;

namespace LAB2.Controllers
{
    public class TodoController : Controller
    {
        // Danh sách tạm thời để lưu trữ các task (trong thực tế sẽ dùng database)
        private static List<TodoItem> todoItems = new List<TodoItem>
        {
            new TodoItem { Id = 1, Task = "Ôn tập HTML" },
            new TodoItem { Id = 2, Task = "Ôn tập CSS" },
            new TodoItem { Id = 3, Task = "Ôn tập Bootstrap" }
        };

        // Action hiển thị danh sách todo
        public IActionResult Index()
        {
            return View(todoItems);
        }

        // Action hiển thị form thêm task mới (GET)
        public IActionResult Add()
        {
            return View();
        }

        // Action xử lý thêm task mới (POST)
        [HttpPost]
        public IActionResult Add(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                // Tạo ID mới
                item.Id = todoItems.Count > 0 ? todoItems.Max(x => x.Id) + 1 : 1;
                todoItems.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // Action hiển thị form chỉnh sửa task (GET)
        public IActionResult Edit(int id)
        {
            var item = todoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // Action xử lý chỉnh sửa task (POST)
        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                var existingItem = todoItems.FirstOrDefault(x => x.Id == item.Id);
                if (existingItem != null)
                {
                    existingItem.Task = item.Task;
                    return RedirectToAction("Index");
                }
                return NotFound();
            }
            return View(item);
        }

        // Action xóa task
        public IActionResult Delete(int id)
        {
            var item = todoItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                todoItems.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}