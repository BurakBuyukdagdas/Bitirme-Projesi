using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworl;
using Microsoft.AspNetCore.Mvc;

namespace CV.ViewComponents.Dasboard
{
    public class ToDoListPanel:ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }

    }
}
