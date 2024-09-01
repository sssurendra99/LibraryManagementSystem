using System;
using LibraryManagementSystem.enums;

namespace LibraryManagementSystem
{
    namespace classes
    {
        public class Member
        {
            private static int s_memberID = 1000;
            public string? Name {get; set;}

            public int MemberId {get; private set;}
            
            public MemberType LibraryMemberType {get; set;}

            public int NumberOfBooksBorrowed {get; set;}

            public Member()
            {
                MemberId = s_memberID;
                s_memberID++;
            }

            public Member(string name, MemberType _memberType)
            {
                this.Name = name;
                this.LibraryMemberType = _memberType;

                MemberId = s_memberID;
                s_memberID++;

            }

        }
    }
}