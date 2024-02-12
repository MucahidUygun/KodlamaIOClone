using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ICourseService
    {
        void Add (AddCourseRequest course);
        GetByIdCourseResponse getByIdCourse (int id);
        List<GetAllCourseResponse> getAllCourse();
        void Update (UpdateCourseRequest course);
        void Delete (DeleteCourseRequest course);
    }
}
