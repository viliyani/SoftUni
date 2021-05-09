using Suls.Data;
using System;
using System.Linq;

namespace Suls.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly ApplicationDbContext db;
        private readonly Random random;

        public SubmissionsService(ApplicationDbContext db, Random random)
        {
            this.db = db;
            this.random = random;
        }

        public void Create(string problemId, string userId, string code)
        {
            var problemMaxPoints = db.Problems
                .Where(x => x.Id == problemId)
                .Select(x => x.Points)
                .FirstOrDefault();

            var submission = new Submission
            {
                Code = code,
                ProblemId = problemId,
                UserId = userId,
                AchievedResult = (ushort)random.Next(0, problemMaxPoints + 1),
                CreatedOn = DateTime.UtcNow,
            };

            db.Submissions.Add(submission);
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            var submission = db.Submissions.Find(id);
            db.Submissions.Remove(submission);
            db.SaveChanges();
        }
    }
}
