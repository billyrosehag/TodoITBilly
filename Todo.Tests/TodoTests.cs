using System;
using Xunit;
using TodoITBilly.Model;


namespace Todo.Tests
{
    public class TodoTests
    {
        [Fact]
        public void ReturnTodoInfo()
        {
            //Arrange
            
            string expectedDesc = "Food shipment";
            int exptectedId = 1;
            TodoITBilly.Model.Todo sut = new TodoITBilly.Model.Todo(expectedDesc,exptectedId);

            //Act
            string actualDesc = sut.Description;
            int actualId = sut.ToDoId;

            //Assert
            Assert.Equal(expectedDesc, actualDesc);
            Assert.Equal(exptectedId, actualId);
        }

        [Fact]
        public void GiveExceptionIfNullorWhiteSpaces()
        {

            string expected = null;

            TodoITBilly.Model.Todo sut = new TodoITBilly.Model.Todo(" ", 0);

            Assert.Equal(expected, sut.Description);


        }
    }
}
