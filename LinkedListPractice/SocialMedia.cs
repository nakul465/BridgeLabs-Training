using System;
namespace LinkedListPractice
{
    public class User
    {
        public int userId;
        public string name;
        public int age;
        public List<int> friendIds;
        public User next;

        public User(int userId, string name, int age)
        {
            this.userId = userId;
            this.name = name;
            this.age = age;
            this.friendIds = new List<int>();
            this.next = null;
        }
    }

    public class SocialMedia
    {
        private User head;

        public void AddUser(User newUser)
        {
            if (head == null)
            {
                head = newUser;
                return;
            }

            User temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newUser;
        }

        public void AddFriend(int userId1, int userId2)
        {
            User user1 = SearchById(userId1);
            User user2 = SearchById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            if (!user1.friendIds.Contains(userId2))
                user1.friendIds.Add(userId2);

            if (!user2.friendIds.Contains(userId1))
                user2.friendIds.Add(userId1);
        }

        public void RemoveFriend(int userId1, int userId2)
        {
            User user1 = SearchById(userId1);
            User user2 = SearchById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            user1.friendIds.Remove(userId2);
            user2.friendIds.Remove(userId1);
        }

        public void DisplayFriends(int userId)
        {
            User user = SearchById(userId);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine($"Friends of {user.name}:");

            foreach (int friendId in user.friendIds)
            {
                User friend = SearchById(friendId);

                if (friend != null)
                    Console.WriteLine($"ID: {friend.userId}, Name: {friend.name}");
            }
        }

        public void FindMutualFriends(int userId1, int userId2)
        {
            User user1 = SearchById(userId1);
            User user2 = SearchById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine("Mutual Friends:");

            foreach (int friendId in user1.friendIds)
            {
                if (user2.friendIds.Contains(friendId))
                {
                    User friend = SearchById(friendId);

                    if (friend != null)
                        Console.WriteLine($"ID: {friend.userId}, Name: {friend.name}");
                }
            }
        }

        public User SearchById(int userId)
        {
            User temp = head;

            while (temp != null)
            {
                if (temp.userId == userId)
                    return temp;

                temp = temp.next;
            }

            return null;
        }

        public User SearchByName(string name)
        {
            User temp = head;

            while (temp != null)
            {
                if (temp.name == name)
                    return temp;

                temp = temp.next;
            }

            return null;
        }

        public void CountFriends()
        {
            User temp = head;

            while (temp != null)
            {
                Console.WriteLine(
                    $"{temp.name} has {temp.friendIds.Count} friends"
                );

                temp = temp.next;
            }
        }

        public void DisplayUsers()
        {
            User temp = head;

            while (temp != null)
            {
                Console.WriteLine(
                    $"ID: {temp.userId}, Name: {temp.name}, Age: {temp.age}"
                );

                temp = temp.next;
            }
        }
    }
}

