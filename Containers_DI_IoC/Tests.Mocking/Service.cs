using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.IoC.DI
{

    public class Repository
    {
        private readonly UnitOfWork _unitOfWork;

        public Repository(UnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public void PrintStuff(string text)
        {
            Debug.WriteLine(text);
        }
    }

    public class Service
    {
        private readonly Repository _repository;
        private readonly UnitOfWork _unitOfWork;

        public Service(Repository repo, UnitOfWork uow)
        {
            _repository = repo;
            _unitOfWork = uow;
        }

        public void DoAwesomeness()
        {
            _repository.PrintStuff("Did awesome stuff!");
            bool result = _unitOfWork.Commit();
            Debug.WriteLine(result);
        }
    }

    public class UnitOfWork
    {
        public bool Commit()
        {
            return true;
        }
    }
}
