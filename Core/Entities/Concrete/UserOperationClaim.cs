namespace Core.Entities.Concrete
{
    public class UserOperationClaim: IEntity  //UserOperationClaim seçili iken ampulden Move type to UserOperationClaim.cs dersen onu dosyaya atar. kısa yol
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
