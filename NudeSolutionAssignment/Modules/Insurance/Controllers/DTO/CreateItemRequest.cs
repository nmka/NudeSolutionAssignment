namespace NudeSolutionAssignment.Modules.Insurance.Controllers.DTO
{
    public record CreateItemRequest(
        string name,
        int categoryId,
        float value
    );
}
