using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ITutorService
    {
        void Add(AddTutorRequest tutor);
        GetByIdTutorResponse getByIdTutor(int id);
        List<GetAllTutorResponse> getAllTutor();
        void Update(UpdateTutorRequest tutor);
        void Delete(DeleteTutorRequest tutor);
    }
}
