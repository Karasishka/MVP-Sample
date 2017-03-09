using MVP.Entities;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;

        private BookModel _bookModel;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _bookModel = new BookModel();
        }

        public void CreateBook()
        {
            if (string.IsNullOrEmpty(_view.EnteredName))
            {
                _view.ShowResult(false);
                return;
            }

            var book = new Book();
            book.Name = _view.EnteredName;

            var result = _bookModel.CreateBook(book);
            _view.ShowResult(result);
        }
    }
}
