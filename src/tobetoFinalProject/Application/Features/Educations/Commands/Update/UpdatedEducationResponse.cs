using Core.Application.Responses;

namespace Application.Features.Educations.Commands.Update;

public class UpdatedEducationResponse : IResponse
{
    public Guid Id { get; set; }
    public string EducationStatus { get; set; }
    public string SchoolName { get; set; }
    public string Branch { get; set; }
    public bool IsContinued { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime GraduationDate { get; set; }
}