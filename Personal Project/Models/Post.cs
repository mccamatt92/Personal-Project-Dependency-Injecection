using Amazon.DynamoDBv2.DataModel;

namespace Personal_Project.Models
{
    [DynamoDBTable(tableName:"post")]
    public class Post
    {
        public Post()
        {
            Id = Guid.NewGuid().ToString();
        }
        [DynamoDBHashKey]
        public string Id { get; set; }
        public DateTimeOffset PostDateTime { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
