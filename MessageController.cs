
namespace Admin.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using Newtonsoft.Json;
	using System.Configuration;
	using System.Data.SqlClient;
	using System.Data;
	using System.Web.Http;
	using System.Net.Http;
	using System.Net;
	using Models;
	using static Functions.SignInClass;

	public class AvailableConversations
	{
		public string conversationId { get; set; }
		public string conversationName { get; set; }
		public string lastMessage { get; set; }
		public string lastMessageDate { get; set; }
		public string lastMessageTime { get; set; }
		public int numberOfUnreadMessages { get; set; }
		public int lastMessageId { get; set; }
		//public List<string> conversationParticipants { get; set; }
		//public int numberOfConversationParticipants { get; set; }
	}

	public class MessageInConversation
	{
		public string authorId { get; set; }
		public string message { get; set; }
		public string authorName { get; set; }
		public string messageTimeSent { get; set; }
		public string messageDateSent { get; set; }
		public bool myMessage { get; set; }
		public bool messageWasRead { get; set; }
		public int numberOfPeopleWhoReadMessage { get; set; }
		public string timeWhenMessageWasRead { get; set; }
		public string dateWhenMessageWasRead { get; set; }
		public string messageId { get; set; }
	}



	public class SortedAvailableConversations
	{
		public List<AvailableConversations> sortedAvailableConversations_list { get; set; }
	}


	public class MessageTransferclass
	{
		public string userId { get; set; }
	}


	public class DisplayConversationclass
	{
		public string conversationId { get; set; }
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public bool getAll { get; set; }
        public string ConnectionId { get; set; }
	}

	public class ConversationIdClass
	{
		public string conversationId { get; set; }
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public string ConnectionId { get; set; }

    }

	public class SendMessageReturnClass
	{
		public bool success { get; set; }
		public bool addParticipants { get; set; }
		public string conversationId { get; set; }
        public string createdMessageId { get; set; }
        public string [] createdDatetime { get; set; }
	}


	public class SendMessageInput
	{
		public string messageConversationId { get; set; }
		public string message { get; set; }
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public string ConnectionId { get; set; }
    }


	public class AddParticipantsInConversationInput
	{
		public string[] userIdsInConversation { get; set; }
		public string conversationId { get; set; }
		public string conversationName { get; set; }
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public string ConnectionId { get; set; }

    }


	public class AddParticipantsInConversationReturn
	{
		public bool success { get; set; }
    }


    public class RemoveConversationClass
    {
        public string conversationId { get; set; }
        public string userId { get; set; }
        public bool webVersion { get; set; }
        public string ConnectionId { get; set; }
    }


    public class RemoveSeveralConversations
    {
        public string userId { get; set; }
        public bool webVersion { get; set; }
        public List<string> chosenConversationIdsForRemoval { get; set; }
    }


    public class RemoveSeveralMessages
    {
        public string userId { get; set; }
        public bool webVersion { get; set; }
        public List<string> chosenMessagesForRemoval { get; set; }
    }


    public class RemoveMessageClass
	{
		public string messageId { get; set; }
        public bool webVersion { get; set; }
        public string ConnectionId { get; set; }

    }


	public class CheckIfConvExists
	{
		public string[] userIdsInConversation { get; set; }
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public string ConnectionId { get; set; }

    }


	public class CheckIfConvExistsReturnClass
	{
		public bool success { get; set; }
		public string conversationId { get; set; }
		public string conversationName { get; set; }
	}



	public class ActionsHappeningWithParticipant
	{
		public List<int> participantIds { get; set; }
		public int conversationId { get; set; }
		public int newNumberOfConversationParticipants { get; set; }
        public bool webVersion { get; set; }
        public string ConnectionId { get; set; }

    }


	public class UniversalOnlyForWebVersion
	{
		public string userId { get; set; }
		public string customerId { get; set; }
		public bool webVersion { get; set; }
        public string ConnectionId { get; set; }
    }


    public class GetPredefinedMessages_class
    {
        public string customerId { get; set; }
        public string employeeType { get; set; }
        public bool webVersion { get; set; }
        public string ConnectionId { get; set; }
    }




    public class CreatePredefinedMessage_class
    {
        public string customerId { get; set; }
        public string employeeType { get; set; }
        public string newPredefinedMessage { get; set; }
        public bool webVersion { get; set; }
    }




    public class GetInfoAboutReadMessages_returnClass
    {
        public Dictionary<string, List<string>> listOfInfoAboutMessage { get; set; }
        public bool thereIsAnyInfoAboutMessage { get; set; }
    }



    public class UserTypeClass
	{
		public int UserTypeId { get; set; }
		public string UserType { get; set; }
		public List<UsersClass> UsersData { get; set; }
	}

	public class UsersClass
	{
		public int UserId { get; set; }
		public string UserNo { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int UserTypeId { get; set; }
	}
    

    public class RemovePredefinedMessage_class
    {
        public string predefinedMessageId { get; set; }
        public bool webVersion { get; set; }
    }


    public class EditPredefinedMessage_class
    {
        public string predefinedMessageId { get; set; }
        public string newPredefinedMessage { get; set; }
        public bool webVersion { get; set; }
    }
    
    public class GetConversationParticipants_returnClass
    {
        public Dictionary<int, List<string>> listOfConversationParticipants { get; set; }
        public bool youAreConversationAdmin { get; set; }
    }


    public class MessageIdInput
    {
        public int messageId { get; set; }
        //public string conversationId { get; set;}
        public bool webVersion { get; set; }
        public string ConnectionId { get; set; }
    }


    public class RenameConversationClass
    {
        public bool webVersion { get; set; }
        public string newConversationName { get; set; }
        public string chosenConversationId { get; set; }
    }


    public class MessageController : ApiController
	{

		public Functionlib ReturnConnectionObject(string _connectionId, bool webVersion)
        {

            Functionlib _Flib;

			if (webVersion == true)
			{
				SignInRootClass _SigninRootClass;
				string _ConnectionId;
				_SigninRootClass = JsonConvert.DeserializeObject<SignInRootClass>(HttpContext.Current.Session["company_name"].ToString());
				_ConnectionId = _SigninRootClass.UserSignIn.ConnectionId;
				_Flib = new Functionlib(_ConnectionId);
				return _Flib;
			}
			else
			{
				_Flib = new Functionlib(_connectionId);
				return _Flib;
			}
		}


		public string ReturnUserId()
		{
			SignInRootClass _SigninRootClass;
			int _SignedInUserId;
			_SigninRootClass = JsonConvert.DeserializeObject<SignInRootClass>(HttpContext.Current.Session["company_name"].ToString());
			_SignedInUserId = _SigninRootClass.UserSignIn.UserId;
			return _SignedInUserId.ToString();
		}


		public string ReturnCustomerId()
		{
			SignInRootClass _SigninRootClass;
			int _SignedInUserCustomerId;
			_SigninRootClass = JsonConvert.DeserializeObject<SignInRootClass>(HttpContext.Current.Session["company_name"].ToString());
			_SignedInUserCustomerId = _SigninRootClass.UserSignIn.CustomerId;
			return _SignedInUserCustomerId.ToString();
		}




		//////////////// Usertypes & Users //////////////////////////////////////////



		[HttpPost]
		[Route("api/message/getusertypes")]
		public HttpResponseMessage GetUserTypes(UniversalOnlyForWebVersion uofwv_cl)
		{

            try
            {
                if (HttpContext.Current.Session["company_name"] == null && uofwv_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    Functionlib _Flib;

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (uofwv_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = uofwv_cl.userId;
                        customerId = uofwv_cl.customerId;
                        _Flib = ReturnConnectionObject(uofwv_cl.ConnectionId, false);
                    }
                    company_nameDataContext db = _Flib.db;
                    var currentDateTime = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId));

                    List<UsersClass> _ListUsers = (from Users in db.tblUsers
                                                   join Schedule in db.tblSchedules on Users.UserId equals Schedule.UserId
                                                   where Users.CustomerId == Convert.ToInt32(customerId) && Users.Status == 1
                                                   && Schedule.CustomerId == Convert.ToInt32(customerId) && Schedule.RegDate == currentDateTime
                                                   select new UsersClass()
                                                   {
                                                       UserId = Users.UserId,
                                                       UserNo = Users.UserNo,
                                                       FirstName = Users.FirstName,
                                                       LastName = Users.LastName,
                                                       UserTypeId = Convert.ToInt32(Users.UserTypeId)
                                                   }).ToList();

                    List<UserTypeClass> _ListUserType = (from UserType in db.tblUserTypes
                                                         where UserType.CustomerId == Convert.ToInt32(customerId) && UserType.UserTypeLevel > 0
                                                         && _ListUsers.Select(u => u.UserTypeId).Contains(UserType.UserTypeId)
                                                         orderby UserType.UserTypeLevel, UserType.Sort
                                                         select new UserTypeClass()
                                                         {
                                                             UserTypeId = UserType.UserTypeId,
                                                             UserType = UserType.UserType,
                                                         }).ToList();

                    foreach (var _CurrentUserTypeObj in _ListUserType)
                    {
                        _CurrentUserTypeObj.UsersData = _ListUsers.Where(u => u.UserTypeId == _CurrentUserTypeObj.UserTypeId).ToList();
                    }

                    List <UserTypeClass> mergedUniqueGroups = new List<UserTypeClass> ();

                    for (int i = 0; i < _ListUserType.Count - 1; i ++)
                    {
                        var uniqueGroupFirst = _ListUserType[i];
                        
                        for (int j = (i + 1); j < _ListUserType.Count; j++)
                        {
                            var uniqueGroupSecond = _ListUserType[j];

                            string mergedName = uniqueGroupFirst.UserType + " & " + uniqueGroupSecond.UserType;

                            if (!mergedName.Contains("GRA"))
                            {

                                List<UsersClass> mergedUsersData = uniqueGroupFirst.UsersData.Union(uniqueGroupSecond.UsersData).ToList();
                                UserTypeClass mergedUTC_cl = new UserTypeClass
                                {
                                    UsersData = mergedUsersData,
                                    UserType = mergedName
                                };
                                mergedUniqueGroups.Add(mergedUTC_cl);
                            }
                        }
                    }

                    //Console.WriteLine(mergedUniqueGroups);

                    List<UserTypeClass> finalListWithMergedGroups = _ListUserType.Union(mergedUniqueGroups).ToList ();

                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(finalListWithMergedGroups));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
		}



        [HttpPost]
        [Route("api/message/getpredefinedmessages")]
        public HttpResponseMessage GetPredefinedMessages(GetPredefinedMessages_class gpm_cl)
        {

            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && gpm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {


                    string employeeType = gpm_cl.employeeType;
                    string customerId = string.Empty;

                    if (gpm_cl.webVersion == true)
                    {
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        customerId = gpm_cl.customerId;
                        _Flib = ReturnConnectionObject(gpm_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();


                    string sqlToGetPredefinedMessages = @"SELECT Id, PredefinedMessage FROM tblMessagePredefinedMessages
	                                            WHERE CustomerId = @customerId AND EmployeeType = @employeeType";

                    Dictionary<string, string> userData_dict = new Dictionary<string, string>();
                    
                    SqlCommand cmd = new SqlCommand(sqlToGetPredefinedMessages, conn);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@employeeType", customerId);

                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        int j = 0;
                        while (dt.Read())
                        {
                            userData_dict[dt[0].ToString()] = dt[1].ToString();
                            j++;
                        }
                    }
                    
                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(userData_dict));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }



        [HttpPost]
        [Route("api/message/removepredefinedmessage")]
        public HttpResponseMessage RemovePredefinedMessage(RemovePredefinedMessage_class rpm_cl)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rpm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    
                    Functionlib _Flib;
                    _Flib = ReturnConnectionObject("", true);

                    conn = _Flib.getConnection();

                    string sqlToRemovePredefinedMessage = @"DELETE FROM tblMessagePredefinedMessages
                            WHERE Id=@predefinedMessageId";
                    
                    SqlCommand cmdToRemovePredefinedMessage = new SqlCommand(sqlToRemovePredefinedMessage, conn);
                    cmdToRemovePredefinedMessage.Parameters.AddWithValue("@predefinedMessageId", rpm_cl.predefinedMessageId);

                    cmdToRemovePredefinedMessage.ExecuteNonQuery();

                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }




        [HttpPost]
        [Route("api/message/editpredefinedmessage")]
        public HttpResponseMessage EditPredefinedMessage(EditPredefinedMessage_class epm_cl)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && epm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    Functionlib _Flib;
                    _Flib = ReturnConnectionObject("", true);

                    conn = _Flib.getConnection();


                    string sqlToUpdatePredefinedMessage = @"UPDATE tblMessagePredefinedMessages 
                    SET PredefinedMessage=@newPredefinedMessage
                    WHERE Id=@predefinedMessageId";

                    
                    SqlCommand cmdToUpdatePredefinedMessageoUpdatePredefinedMessage =
                        new SqlCommand(sqlToUpdatePredefinedMessage, conn);
                    cmdToUpdatePredefinedMessageoUpdatePredefinedMessage.Parameters.
                        AddWithValue("@newPredefinedMessage", epm_cl.newPredefinedMessage);
                    cmdToUpdatePredefinedMessageoUpdatePredefinedMessage.Parameters.
                        AddWithValue("@predefinedMessageId", epm_cl.predefinedMessageId);
                    

                    cmdToUpdatePredefinedMessageoUpdatePredefinedMessage.ExecuteNonQuery();

                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }




        [HttpPost]
        [Route("api/message/createpredefinedmessage")]
        public HttpResponseMessage CreatePredefinedMessage(CreatePredefinedMessage_class cpm_cl)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && cpm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    Functionlib _Flib;
                    _Flib = ReturnConnectionObject("", true);

                    conn = _Flib.getConnection();

                    string newPredefinedMessage = cpm_cl.newPredefinedMessage;
                    string employeeType = cpm_cl.employeeType;
                    string customerId = string.Empty;

                    if (cpm_cl.webVersion == true)
                    {
                        customerId = ReturnCustomerId();
                    }
                    else
                    {
                        customerId = cpm_cl.customerId;
                    }

                    string sqlToCreatePredefinedMessage = @"INSERT INTO tblMessagePredefinedMessages VALUES
                (@customerId, @employeeType, @newPredefinedMessage)";
                    
                    SqlCommand cmdToCreatePredefinedMessage = new SqlCommand(sqlToCreatePredefinedMessage, conn);
                    cmdToCreatePredefinedMessage.Parameters.AddWithValue("@customerId", customerId);
                    cmdToCreatePredefinedMessage.Parameters.AddWithValue("@employeeType", employeeType);
                    cmdToCreatePredefinedMessage.Parameters.AddWithValue("@newPredefinedMessage", newPredefinedMessage);

                    cmdToCreatePredefinedMessage.ExecuteNonQuery();
                    

                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }


        [HttpPost]
        [Route("api/message/checkifyoucreatedconversation")]
        public HttpResponseMessage CheckIfYouCreatedConversation(RemoveConversationClass rc_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rc_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;

                    if (rc_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        _Flib = ReturnConnectionObject("", true);

                        //  technically, since only admins can login...
                        return Request.CreateResponse(HttpStatusCode.OK, true);

                    }
                    else
                    {
                        userId = rc_cl.userId;
                        _Flib = ReturnConnectionObject(rc_cl.ConnectionId, false);

                        conn = _Flib.getConnection();

                        string conversationId = rc_cl.conversationId;



                        string sqlToGetOwnedIdOfConversation = @"SELECT OwnerId FROM tblMessageConversation
                        WHERE ConversationId = @conversationId";

                        SqlCommand cmdToGetOwnedIdOfConversation = new SqlCommand(sqlToGetOwnedIdOfConversation, conn);
                        cmdToGetOwnedIdOfConversation.Parameters.AddWithValue("@conversationId", conversationId);

                        string ownerId = cmdToGetOwnedIdOfConversation.ExecuteScalar().ToString();

                        if (ownerId == userId)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, true);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, false);
                        }
                    }
                    
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }


        [HttpPost]
        [Route("api/message/removeseveralconversations")]
        public HttpResponseMessage RemoveSeveralConversations(RemoveSeveralConversations rsc_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rsc_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    if (rsc_cl.chosenConversationIdsForRemoval.Count > 0)
                    {

                        string userId = string.Empty;

                        userId = ReturnUserId();
                        _Flib = ReturnConnectionObject("", true);
                        conn = _Flib.getConnection();

                        foreach (string conversationId in rsc_cl.chosenConversationIdsForRemoval)
                        {
                            
                            string sqlToDeleteInfoAboutConversationId = @"DELETE FROM tblMessageConversation 
                            WHERE ConversationId = @conversationId";
                            string sqlToDeleteInfoAboutConversationParticipants = @"DELETE FROM tblMessageConversationParticipants 
                            WHERE ConversationId = @conversationId";

                            SqlCommand cmdToDeleteInfoAboutConversationId = new SqlCommand(sqlToDeleteInfoAboutConversationId,
                                conn);
                            cmdToDeleteInfoAboutConversationId.Parameters.AddWithValue("@conversationId", conversationId);
                            cmdToDeleteInfoAboutConversationId.ExecuteNonQuery();

                            SqlCommand cmdToDeleteInfoAboutConversationParticipants = new SqlCommand(sqlToDeleteInfoAboutConversationParticipants,
                                conn);
                            cmdToDeleteInfoAboutConversationParticipants.Parameters.AddWithValue("@conversationId", conversationId);
                            cmdToDeleteInfoAboutConversationParticipants.ExecuteNonQuery();
                        }
                        return Request.CreateResponse(HttpStatusCode.OK, true);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Something went wrong, contact the administrator");
                    }
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }



        [HttpPost]
        [Route("api/message/removeseveralmessages")]
        public HttpResponseMessage RemoveSeveralMessages(RemoveSeveralMessages rsm_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rsm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    if (rsm_cl.chosenMessagesForRemoval.Count > 0)
                    {

                        string userId = string.Empty;

                        userId = ReturnUserId();
                        _Flib = ReturnConnectionObject("", true);
                        conn = _Flib.getConnection();

                        foreach (string messageId in rsm_cl.chosenMessagesForRemoval)
                        {
                            RemoveIndividualMessage(conn, messageId);
                        }
                        
                        return Request.CreateResponse(HttpStatusCode.OK, true);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Something went wrong, contact the administrator");
                    }
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }



        [HttpPost]
        [Route("api/message/removeconversation")]
        public HttpResponseMessage RemoveConversation (RemoveConversationClass rc_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rc_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;

                    string conversationId = rc_cl.conversationId;

                    if (rc_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        _Flib = ReturnConnectionObject("", true);

                        conn = _Flib.getConnection();

                        //  if you are from a PC, you can remove a conversation, tbh
                        ActuallyRemoveConversation(conversationId, conn);
                        return Request.CreateResponse(HttpStatusCode.OK, true);
                    }
                    else
                    {
                        userId = rc_cl.userId;
                        _Flib = ReturnConnectionObject(rc_cl.ConnectionId, false);
                        conn = _Flib.getConnection();


                        //  if you are from a mobile version, then you have to be an owner
                        string sqlToGetOwnedIdOfConversation = @"SELECT OwnerId FROM tblMessageConversation
                        WHERE ConversationId = @conversationId";

                        SqlCommand cmdToGetOwnedIdOfConversation = new SqlCommand(sqlToGetOwnedIdOfConversation, conn);
                        cmdToGetOwnedIdOfConversation.Parameters.AddWithValue("@conversationId", conversationId);

                        string ownerId = cmdToGetOwnedIdOfConversation.ExecuteScalar().ToString();

                        if (ownerId == userId)
                        {
                            ActuallyRemoveConversation(conversationId, conn);
                            return Request.CreateResponse(HttpStatusCode.OK, true);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, false);
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


        void ActuallyRemoveConversation (string conversationId, SqlConnection conn)
        {
            string sqlToDeleteInfoAboutConversationId = @"DELETE FROM tblMessageConversation 
                            WHERE ConversationId = @conversationId";
            string sqlToDeleteInfoAboutConversationParticipants = @"DELETE FROM tblMessageConversationParticipants 
                            WHERE ConversationId = @conversationId";

            SqlCommand cmdToDeleteInfoAboutConversationId = new SqlCommand(sqlToDeleteInfoAboutConversationId,
                conn);
            cmdToDeleteInfoAboutConversationId.Parameters.AddWithValue("@conversationId", conversationId);
            cmdToDeleteInfoAboutConversationId.ExecuteNonQuery();

            SqlCommand cmdToDeleteInfoAboutConversationParticipants = new SqlCommand(sqlToDeleteInfoAboutConversationParticipants,
                conn);
            cmdToDeleteInfoAboutConversationParticipants.Parameters.AddWithValue("@conversationId", conversationId);
            cmdToDeleteInfoAboutConversationParticipants.ExecuteNonQuery();
        }


		[HttpPost]
		[Route("api/message/removemessage")]
		public HttpResponseMessage RemoveMessage(RemoveMessageClass rm_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rm_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    if (rm_cl.webVersion == true)
                    {
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        _Flib = ReturnConnectionObject(rm_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    string messageId = rm_cl.messageId;

                    RemoveIndividualMessage(conn, messageId);

                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }


        void RemoveIndividualMessage (SqlConnection conn, string messageId)
        {
            string sqlRemoveYourMessage = @"UPDATE tblMessageStatus SET Deleted=1 WHERE MessageId=@messageId";

            //  write a message
            SqlCommand cmdToRemoveYourMessage = new SqlCommand(sqlRemoveYourMessage, conn);
            cmdToRemoveYourMessage.Parameters.AddWithValue("@messageId", messageId);

            cmdToRemoveYourMessage.ExecuteNonQuery();
        }


        [HttpPost]
        [Route("api/message/renameconversation")]
        public HttpResponseMessage RenameConversation(RenameConversationClass rc_cl)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && rc_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    Functionlib _Flib;
                    _Flib = ReturnConnectionObject("", true);

                    conn = _Flib.getConnection();


                    string sqlToUpdateConversationName = @"UPDATE tblMessageConversation 
                        SET ConversationName=@newConversationName
                        WHERE ConversationId=@conversationId";


                    SqlCommand cmdToUpdateConversationName =
                        new SqlCommand(sqlToUpdateConversationName, conn);
                    cmdToUpdateConversationName.Parameters.
                        AddWithValue("@newConversationName", rc_cl.newConversationName);
                    cmdToUpdateConversationName.Parameters.
                        AddWithValue("@conversationId", rc_cl.chosenConversationId);


                    cmdToUpdateConversationName.ExecuteNonQuery();

                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }


        [HttpPost]
        [Route("api/message/getallcontactsforapp")]
        public HttpResponseMessage GetAllContactsForApp(UniversalOnlyForWebVersion uofwv_cl)
        {

            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && uofwv_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;
                    string customerId = string.Empty;
                    string neededUserTypesForHousekeepingApp = string.Empty;


                    userId = uofwv_cl.userId;
                    customerId = uofwv_cl.customerId;
                    _Flib = ReturnConnectionObject(uofwv_cl.ConnectionId, false);
                    conn = _Flib.getConnection();


                    var currentDateTime = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId)).ToString();
                    DateTime _Today = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId));

                    var todaysManagersAndSimilar = _Flib.getHSKManagersAndInspectors(_Today, Convert.ToInt32(customerId));
                    var yourTodaysGRAs = _Flib.getHSKManagersCleaners(_Today, Convert.ToInt32(customerId), Convert.ToInt32(userId));

                    var totalPeopleWithoutAdministration = yourTodaysGRAs.Union(todaysManagersAndSimilar);
                    Dictionary<int, List<string>> userData_dict = new Dictionary<int, List<string>>();

                    int j = 0;
                    foreach (var person in totalPeopleWithoutAdministration)
                    {
                        List<string> infoAboutPerson = new List<string>();
                        infoAboutPerson.Add(person.UserId.ToString());
                        infoAboutPerson.Add(person.UserName);
                        infoAboutPerson.Add(person.UserNo);
                        infoAboutPerson.Add(person.UserType);
                        userData_dict.Add(j, infoAboutPerson);
                        j++;
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(userData_dict));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }

        [HttpPost]
		[Route("api/message/getallcontacts")]
		public HttpResponseMessage GetAllContacts(UniversalOnlyForWebVersion uofwv_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && uofwv_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;
                    string customerId = string.Empty;
                    string neededUserTypesForHousekeepingApp = string.Empty;


                    if (uofwv_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = uofwv_cl.userId;
                        customerId = uofwv_cl.customerId;
                        _Flib = ReturnConnectionObject(uofwv_cl.ConnectionId, false);

                        //  this is something that I have to figure out for other customers, since all of them have different user types
                        if (customerId == "1")
                        {
                            neededUserTypesForHousekeepingApp = "104,105,26,115,113,2";
                        }
                        else if (customerId == "2")
                        {
                            neededUserTypesForHousekeepingApp = "116,114,3,7,108,109";
                        }
                    }
                    conn = _Flib.getConnection();


                    string sql = string.Empty;

                    //  in web version, display everyone
                    if (uofwv_cl.webVersion == true)
                    {
                        sql = @"SELECT UserId, (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName, UserNo
                            FROM tblUser WHERE CustomerId=@customerId AND NOT UserId = @id ORDER BY tblUser.LastName ASC";
                    }
                    else
                    {
                        if (neededUserTypesForHousekeepingApp == string.Empty)
                        {
                            sql = @"SELECT UserId, (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName, UserNo
                            FROM tblUser WHERE CustomerId=@customerId AND NOT UserId = @id ORDER BY tblUser.LastName ASC";
                        }
                        else
                        {
                            sql = @"SELECT UserId, (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName, UserNo
                            FROM tblUser WHERE CustomerId=@customerId AND UserTypeId IN (" +
                                neededUserTypesForHousekeepingApp + ") AND NOT UserId = @id ORDER BY tblUser.LastName ASC";
                        }
                    }

                    Dictionary<int, List<string>> userData_dict = new Dictionary<int, List<string>>();
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        int j = 0;
                        while (dt.Read())
                        {
                            //Console.WriteLine(dt);
                            List<string> userData_list = new List<string>();
                            for (int i = 0; i < dt.FieldCount; i++)
                            {
                                userData_list.Add(dt[i].ToString());
                            }
                            userData_dict[j] = userData_list;
                            j++;
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(userData_dict));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }




		[HttpPost]
		[Route("api/message/getallpeoplewhoarentparticipantsinconversation")]
		public HttpResponseMessage GetAllPeopleWhoArentParticipantsInConversation(ConversationIdClass cic_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && cic_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (cic_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = cic_cl.userId;
                        customerId = cic_cl.customerId;
                        _Flib = ReturnConnectionObject(cic_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();


                    string conversationId = cic_cl.conversationId;


                    string sql = @"SELECT  UserId, (tblUser.LastName + ' ' + tblUser.FirstName) AS userFullName, UserNo FROM tblUser 
                            WHERE CustomerId=@customerId AND NOT UserId = @userId
	                        AND UserId NOT IN (SELECT ConversationParticipantUserId FROM tblMessageConversationParticipants
	                        WHERE ConversationId = @conversationId) ORDER BY tblUser.LastName ASC";

                    Dictionary<int, List<string>> userData_dict = new Dictionary<int, List<string>>();
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@conversationId", conversationId);

                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        int j = 0;
                        while (dt.Read())
                        {
                            //Console.WriteLine(dt);
                            List<string> userData_list = new List<string>();
                            for (int i = 0; i < dt.FieldCount; i++)
                            {
                                userData_list.Add(dt[i].ToString());
                            }
                            userData_dict[j] = userData_list;
                            j++;
                        }
                    }
                    
                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(userData_dict));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }
        

                    

        [HttpPost]
        [Route("api/message/getallpeoplewhoarentparticipantsinconversationforapp")]
        public HttpResponseMessage GetAllPeopleWhoArentParticipantsInConversationForApp(ConversationIdClass cic_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && cic_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;
                    string customerId = string.Empty;
                    string neededUserTypesForHousekeepingApp = string.Empty;


                    userId = cic_cl.userId;
                    customerId = cic_cl.customerId;
                    _Flib = ReturnConnectionObject(cic_cl.ConnectionId, false);
                    conn = _Flib.getConnection();
                    string conversationId = cic_cl.conversationId;

                    string sql = @"SELECT ConversationParticipantUserId FROM tblMessageConversationParticipants
	                        WHERE ConversationId = @conversationId";

                    List<string> listOfAlreadyExistingParticipants = new List<string>();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@conversationId", conversationId);

                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        while (dt.Read())
                        {
                            //Console.WriteLine(dt);
                            List<string> userData_list = new List<string>();
                            for (int i = 0; i < dt.FieldCount; i++)
                            {
                                listOfAlreadyExistingParticipants.Add(dt[i].ToString());
                            }
                        }
                    }

                    var currentDateTime = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId)).ToString();
                    DateTime _Today = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId));

                    var todaysManagersAndSimilar = _Flib.getHSKManagersAndInspectors(_Today, Convert.ToInt32(customerId));
                    var yourTodaysGRAs = _Flib.getHSKManagersCleaners(_Today, Convert.ToInt32(customerId), Convert.ToInt32(userId));

                    var totalPeopleWithoutAdministration = yourTodaysGRAs.Union(todaysManagersAndSimilar);
                    Dictionary<int, List<string>> userData_dict = new Dictionary<int, List<string>>();

                    int j = 0;
                    foreach (var person in totalPeopleWithoutAdministration)
                    {
                        List<string> infoAboutPerson = new List<string>();
                        infoAboutPerson.Add(person.UserId.ToString());
                        infoAboutPerson.Add(person.UserName);
                        infoAboutPerson.Add(person.UserNo);
                        infoAboutPerson.Add(person.UserType);
                        userData_dict.Add(j, infoAboutPerson);
                        j++;
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(userData_dict));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }




        public class GetAllAvailableConversations_inputClass
        {
            public string userId { get; set; }
            public string customerId { get; set; }
            public bool webVersion { get; set; }
            public bool getAll { get; set; }
            public string ConnectionId { get; set; }
        }


        [HttpPost]
		[Route("api/message/getallavailableconversations")]
		public HttpResponseMessage GetAllAvailableConversations(GetAllAvailableConversations_inputClass gac_cl)
		{


            int maxNumberOfConversationToGrab = 30;

            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && gac_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (gac_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();

                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = gac_cl.userId;
                        customerId = gac_cl.customerId;

                        _Flib = ReturnConnectionObject(gac_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    string sqlToGetConversationIds = string.Empty;

                    if (gac_cl.getAll == false)
                    {
                        maxNumberOfConversationToGrab = 30;
                    }
                    else
                    {
                        maxNumberOfConversationToGrab = 500;
                    }

                    string sqlToGetAllInfoAboutConvos = "SELECT TOP " + maxNumberOfConversationToGrab + @" * FROM
		                (SELECT tblMessage.ConversationId, MAX (tblMessage.MessageId) AS LatestMessageId,
		                'LastMessage' = 
			                CASE 
				                WHEN LEN (tblMessage.Message) >= 10
					                THEN (SUBSTRING(tblMessage.Message, 1, 7) + '...')
				                WHEN LEN (tblMessage.Message) < 10
					                THEN tblMessage.Message
			                END,
		                'ConversationName' = 
			                CASE 
				                WHEN tblMessageConversation.ConversationNumberOfParticipants = 2 AND tblMessageConversation.ConversationName IS NULL
					                THEN (SELECT (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName 
							                FROM tblMessageConversationParticipants
							                JOIN tblUser ON tblUser.UserId = tblMessageConversationParticipants.conversationParticipantUserId
							                WHERE tblMessageConversationParticipants.ConversationId = tblMessage.ConversationId 
								                AND NOT tblUser.UserId = @userId)
				                WHEN tblMessageConversation.ConversationNumberOfParticipants = 2 AND tblMessageConversation.ConversationName IS NOT NULL
					                THEN (SELECT tblMessageConversation.ConversationName FROM tblMessageConversation 
					                WHERE tblMessageConversation.ConversationId = tblMessage.ConversationId)
				                WHEN tblMessageConversation.ConversationNumberOfParticipants <> 2
					                THEN (SELECT tblMessageConversation.ConversationName FROM tblMessageConversation 
					                WHERE tblMessageConversation.ConversationId = tblMessage.ConversationId)
			                END
		                FROM tblMessage
		                JOIN tblMessageConversation ON tblMessageConversation.ConversationId = tblMessage.ConversationId
	                    WHERE tblMessage.ConversationId IN 
                                (SELECT tblMessageConversationParticipants.ConversationId FROM tblMessageConversationParticipants 
                                        WHERE tblMessageConversationParticipants.ConversationParticipantUserId = @userId)
	                    GROUP BY tblMessage.ConversationId, tblMessage.Message,
		                tblMessageConversation.ConversationNumberOfParticipants, tblMessageConversation.ConversationName) AS t1
		                JOIN
		                (SELECT TOP " + maxNumberOfConversationToGrab + @" a.*, tblMessageStatus.CreatedDate, tblMessageStatus.CreatedTime,
	                (SELECT COUNT (tblMessage.MessageId) FROM tblMessage
	                    JOIN tblMessageStatus ON tblMessageStatus.MessageId = tblMessage.MessageId
		                WHERE tblMessageStatus.Deleted = 0 AND tblMessage.ConversationId = a.ConversationId
                            AND NOT tblMessage.AuthorId = @userId
	                    AND tblMessage.MessageId > (SELECT CASE 
			                        WHEN (SELECT MAX (tblMessagesReadByEmployees.MessageId) 
			                        FROM tblMessagesReadByEmployees WHERE tblMessagesReadByEmployees.ConversationId = a.ConversationId) IS NULL
		                        THEN 0
		                        ELSE
			                        (SELECT MAX (tblMessagesReadByEmployees.MessageId) 
			                        FROM tblMessagesReadByEmployees WHERE tblMessagesReadByEmployees.ConversationId = a.ConversationId)
		                        END))
		                AS NumberOfUnreadMessages
	                FROM (SELECT tblMessage.ConversationId, MAX (tblMessage.MessageId) AS latestMessageId FROM tblMessage
	                    WHERE tblMessage.ConversationId in 
                                (SELECT tblMessageConversationParticipants.ConversationId FROM tblMessageConversationParticipants 
                                        WHERE tblMessageConversationParticipants.ConversationParticipantUserId = @userId)
	                    GROUP BY tblMessage.ConversationId) a
		                INNER JOIN tblMessageStatus ON
		                tblMessageStatus.MessageId = a.latestMessageId
		                ORDER BY a.latestMessageId DESC) AS t2
		                ON t1.LatestMessageId = t2.LatestMessageId
		                ORDER BY t1.LatestMessageId DESC";
                    

                    List<string> availableConversationIds_list = new List<string>();
                    List<AvailableConversations> availableConversations_list = new List<AvailableConversations>();
                    
                    using (SqlCommand cmdToGetConversations = new SqlCommand(sqlToGetAllInfoAboutConvos, conn))
                    {
                        cmdToGetConversations.Parameters.AddWithValue("@userId", userId);
                        using (SqlDataReader dt = cmdToGetConversations.ExecuteReader())
                        {
                            if (dt.HasRows)
                            {
                                while (dt.Read())
                                {

                                    AvailableConversations ac = new AvailableConversations();

                                    ac.conversationId = dt[0].ToString();
                                    ac.lastMessage = dt[2].ToString().Replace("<br />", "");
                                    ac.conversationName = dt[3].ToString().TrimEnd();
                                    ac.numberOfUnreadMessages = Convert.ToInt32(dt[8].ToString());
                                    string lastMessageDate = dt[6].ToString();
                                    ac.lastMessageDate = lastMessageDate.Contains(" 12:00:00 AM") ?
                                        lastMessageDate.Replace(" 12:00:00 AM", "") : lastMessageDate;
                                    ac.lastMessageTime = dt[7].ToString();
                                    ac.lastMessageId = Convert.ToInt32(dt[1].ToString());

                                    //Console.WriteLine(ac);
                                    availableConversations_list.Add(ac);

                                }
                            }
                        }

                        //var sortedAvailableConversations = availableConversations_list.OrderByDescending(ac => ac.lastMessageId);

                        var sortedByUnreadAvailableConversations = availableConversations_list.
                            OrderByDescending(ac => ac.numberOfUnreadMessages);

                        List<AvailableConversations> sortedAvailableConversations_list = new List<AvailableConversations>();

                        //if (gac_cl.getAll == false)
                        //{
                        //    sortedAvailableConversations_list = sortedByUnreadAvailableConversations.ToList().
                        //        Take(maxNumberOfConversationToGrab).ToList();
                        //}
                        //else
                        //{
                        //    sortedAvailableConversations_list = sortedByUnreadAvailableConversations.ToList();
                        //}

                        SortedAvailableConversations sac_return = new SortedAvailableConversations()
                        {
                            sortedAvailableConversations_list = sortedByUnreadAvailableConversations.ToList()
                        };

                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(sac_return));
                    }
                }   
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		[HttpPost]
		[Route("api/message/displayconversation")]
		public HttpResponseMessage DisplayConversation(DisplayConversationclass displayConversationclass_cl)
		{
            int maxNumberOfInitiallyDisplayedMessages = 50;
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && displayConversationclass_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    List<MessageInConversation> mic_list = new List<MessageInConversation>();


                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (displayConversationclass_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = displayConversationclass_cl.userId;
                        customerId = displayConversationclass_cl.customerId;
                        _Flib = ReturnConnectionObject(displayConversationclass_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    string conversationId = displayConversationclass_cl.conversationId;


                    //  in case it's an empty conversation
                    if (conversationId != "")
                    {


                        string sqlToGetMessagesFromConversation = string.Empty;
                        if (displayConversationclass_cl.getAll == true)
                        {
                            sqlToGetMessagesFromConversation = @"SELECT tblMessage.AuthorId, tblMessage.Message, 
                                (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName,
                                tblMessageStatus.CreatedDate, tblMessageStatus.CreatedTime, 
		                        tblMessage.MessageId, (COUNT (tblMessagesReadByEmployees.id)) AS numberOfTimesMessageWasRead 
		                        FROM tblMessage 
	                            JOIN tblUser ON tblUser.UserId = tblMessage.AuthorId 
	                            AND tblMessage.ConversationId = @conversationId  
                                JOIN tblMessageStatus ON tblMessageStatus.MessageId = tblMessage.MessageId
	                            LEFT OUTER JOIN tblMessagesReadByEmployees ON tblMessage.MessageId = tblMessagesReadByEmployees.MessageId
		                        WHERE tblMessageStatus.Deleted = 0
		                        GROUP BY tblMessage.MessageId, tblMessage.AuthorId, tblMessage.Message,
		                        tblUser.FirstName, tblUser.LastName, tblMessageStatus.CreatedDate, tblMessageStatus.CreatedTime
                                ORDER BY tblMessage.MessageId DESC";
                        }
                        else
                        {
                            sqlToGetMessagesFromConversation = "SELECT TOP " + maxNumberOfInitiallyDisplayedMessages
                                    + @" tblMessage.AuthorId, tblMessage.Message, 
                                    (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName,
                                    tblMessageStatus.CreatedDate, tblMessageStatus.CreatedTime, 
		                            tblMessage.MessageId, (COUNT (tblMessagesReadByEmployees.id)) AS numberOfTimesMessageWasRead 
		                            FROM tblMessage 
	                                JOIN tblUser ON tblUser.UserId = tblMessage.AuthorId 
	                                AND tblMessage.ConversationId = @conversationId 
                                    JOIN tblMessageStatus ON tblMessageStatus.MessageId = tblMessage.MessageId
	                                LEFT OUTER JOIN tblMessagesReadByEmployees ON tblMessage.MessageId = tblMessagesReadByEmployees.MessageId
		                            WHERE tblMessageStatus.Deleted = 0
		                            GROUP BY tblMessage.MessageId, tblMessage.AuthorId, tblMessage.Message,
		                            tblUser.FirstName, tblUser.LastName, tblMessageStatus.CreatedDate, tblMessageStatus.CreatedTime
                                    ORDER BY tblMessage.MessageId DESC";
                        }
                         

                        
                        SqlCommand cmdToGetMessagesFromConversation = new SqlCommand(sqlToGetMessagesFromConversation, conn);
                        cmdToGetMessagesFromConversation.Parameters.AddWithValue("@conversationId", conversationId);

                        SqlDataReader dt_toGetMessagesFromConversation = cmdToGetMessagesFromConversation.ExecuteReader();

                        if (dt_toGetMessagesFromConversation.HasRows)
                        {
                            while (dt_toGetMessagesFromConversation.Read())
                            {
                                MessageInConversation mic_cl = new MessageInConversation()
                                {
                                    authorId = dt_toGetMessagesFromConversation[0].ToString(),
                                    message = dt_toGetMessagesFromConversation[1].ToString(),
                                    authorName = dt_toGetMessagesFromConversation[2].ToString(),
                                    messageDateSent = dt_toGetMessagesFromConversation[3].ToString(),
                                    messageTimeSent = dt_toGetMessagesFromConversation[4].ToString(),
                                    messageId = dt_toGetMessagesFromConversation[5].ToString(),
                                    messageWasRead = true,
                                    numberOfPeopleWhoReadMessage = Convert.ToInt32(dt_toGetMessagesFromConversation[6].ToString())
                                };

                                if (mic_cl.messageDateSent.Contains(" 12:00:00 AM"))
                                {
                                    mic_cl.messageDateSent = mic_cl.messageDateSent.Replace(" 12:00:00 AM", "");
                                }

                                if (mic_cl.authorId == userId)
                                {
                                    //  ur msg
                                    mic_cl.myMessage = true;
                                }
                                else
                                {
                                    mic_cl.myMessage = false;
                                }

                                mic_list.Add(mic_cl);
                            }
                        }
                    }
                    
                    string sqlToGetMessagesYouDidntReadFromConvo = @"SELECT tblMessage.MessageId FROM tblMessage
	                        JOIN tblMessageStatus ON tblMessageStatus.MessageId = tblMessage.MessageId
			                WHERE tblMessageStatus.Deleted = 0 AND tblMessage.ConversationId = @conversationId 
                                AND NOT tblMessage.AuthorId = @userId
	                        AND tblMessage.MessageId > (SELECT MAX (tblMessagesReadByEmployees.MessageId) 
                            FROM tblMessagesReadByEmployees WHERE tblMessagesReadByEmployees.ConversationId = @conversationId)";

                    List<string> unreadMessages = new List<string>();

                    SqlCommand cmd = new SqlCommand(sqlToGetMessagesYouDidntReadFromConvo, conn);
                    cmd.Parameters.AddWithValue("@conversationId", displayConversationclass_cl.conversationId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        while (dt.Read())
                        {
                            for (int i = 0; i < dt.FieldCount; i++)
                            {
                                unreadMessages.Add(dt[i].ToString());
                            }
                        }
                    }

                    if (unreadMessages.Count > 0)
                    {
                        foreach (string unreadMessageId in unreadMessages)
                        {
                            mic_list.Find(i => i.messageId == unreadMessageId).messageWasRead = false;
                        }
                    }
                    //  since we changed the order
                    mic_list.Reverse();


                    UpdateLastReadWhenOpeningConversation(conversationId, userId, customerId, _Flib, conn);

                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(mic_list));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


        void UpdateLastReadWhenOpeningConversation(string conversationId, string userId, string customerId, Functionlib _flib, SqlConnection conn)
        {
            string sqlToGetLatestMessageInConversation = @"SELECT MAX (tblMessage.MessageId) 
                                                        FROM tblMessage WHERE tblMessage.ConversationId = @conversationId";
            
            SqlCommand cmdToGetLatestMessageInConversation = new SqlCommand(sqlToGetLatestMessageInConversation, conn);
            cmdToGetLatestMessageInConversation.Parameters.AddWithValue("@conversationId", conversationId);

            string latestMessageId = cmdToGetLatestMessageInConversation.ExecuteScalar().ToString();
            //  do something when you are NOT an AUTHOR

            var currentDateTime = _flib.getCustomerTimeZones(Convert.ToInt32(customerId)).ToString();

            DoSomethingWithLastRead(userId, conversationId, latestMessageId, customerId, conn, currentDateTime);
        }


        [HttpPost]
		[Route("api/message/sendmessage")]
		public HttpResponseMessage SendMessage(SendMessageInput smi_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && smi_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {


                    string messageConversationId = smi_cl.messageConversationId;
                    string message = smi_cl.message;


                    string authorId = string.Empty;
                    string customerId = string.Empty;

                    if (smi_cl.webVersion == true)
                    {
                        authorId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        authorId = smi_cl.userId;
                        customerId = smi_cl.customerId;
                        _Flib = ReturnConnectionObject(smi_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();


                    string conversationId = messageConversationId;

                    if (messageConversationId != "")
                    {
                        string sqlToInsertMessagesIntoConversation = @"INSERT INTO tblMessage (ConversationId, AuthorId, Message) 
                        VALUES (@messageConversationId, @authorId, @message);SELECT SCOPE_IDENTITY();";
                        
                        var currentDateTime = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId)).ToString();

                        string[] dateAndTime = currentDateTime.Split(' ');

                        string createdMessageId = CreateMessage("@messageConversationId", "@authorId", "@message", messageConversationId,
                            authorId, message, conn, sqlToInsertMessagesIntoConversation,
                            customerId, currentDateTime);


                        SendMessageReturnClass smrt = new SendMessageReturnClass
                        {
                            success = true,
                            addParticipants = false,
                            conversationId = conversationId,
                            createdMessageId = createdMessageId,
                            createdDatetime = dateAndTime
                        };

                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(smrt));
                    }
                    else
                    {
                        string sqlToCreateConversation = @"INSERT INTO tblMessageConversation (OwnerId) 
                        VALUES (@ownerId);SELECT SCOPE_IDENTITY();";
                        
                        SqlCommand cmdToCreateConversation = new SqlCommand(sqlToCreateConversation, conn);

                        cmdToCreateConversation.Parameters.AddWithValue("@ownerId", authorId);

                        conversationId = cmdToCreateConversation.ExecuteScalar().ToString();
                        

                        string sqlToInsertMessagesIntoConversation = @"INSERT INTO tblMessage (ConversationId, AuthorId, Message) 
                    VALUES (@messageConversationId, @authorId, @message);SELECT SCOPE_IDENTITY();";
                        //  write a message
                        

                        var currentDateTime = _Flib.getCustomerTimeZones(Convert.ToInt32(customerId)).ToString();
                        string createdMessageId = CreateMessage("@messageConversationId", "@authorId", "@message", conversationId,
                            authorId, message, conn,
                            sqlToInsertMessagesIntoConversation, customerId, currentDateTime);

                        string[] dateAndTime = currentDateTime.Split(' ');


                        SendMessageReturnClass smrt = new SendMessageReturnClass
                        {
                            success = true,
                            addParticipants = true,
                            conversationId = conversationId,
                            createdMessageId = createdMessageId,
                            createdDatetime = dateAndTime
                        };

                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(smrt));
                    }
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		string CreateMessage(string par_messageConversationId, string par_authorId, string par_message,
			string val_messageConversationId, string val_authorId, string val_message, SqlConnection conn,
			string sqlToInsertMessagesIntoConversation, string customerId, string currentDateTime)
		{
			SqlCommand cmdToInsertMessagesIntoConversation = new SqlCommand(sqlToInsertMessagesIntoConversation, conn);
			cmdToInsertMessagesIntoConversation.Parameters.AddWithValue(par_messageConversationId, val_messageConversationId);
			cmdToInsertMessagesIntoConversation.Parameters.AddWithValue(par_authorId, val_authorId);
			cmdToInsertMessagesIntoConversation.Parameters.AddWithValue(par_message, val_message);

			string createdMessageId = cmdToInsertMessagesIntoConversation.ExecuteScalar().ToString();

			//Console.WriteLine(createdMessageId);

			DoSomethingWithLastRead(val_authorId, val_messageConversationId, createdMessageId, customerId, conn, currentDateTime);


			string sqlToWriteMessageStatus = @"INSERT INTO tblMessageStatus (MessageId, CreatedDate, CreatedTime, HowManyPeopleRead, Deleted) 
                        VALUES (@messageId, @createdDate, @createdTime, @howManyPeopleRead, @deleted)";
            
			SqlCommand cmdToWriteMessageStatus = new SqlCommand(sqlToWriteMessageStatus, conn);

			string[] dateAndTime = currentDateTime.Split(' ');

			cmdToWriteMessageStatus.Parameters.AddWithValue("@messageId", createdMessageId);
			cmdToWriteMessageStatus.Parameters.AddWithValue("@createdDate", dateAndTime[0]);
			cmdToWriteMessageStatus.Parameters.AddWithValue("@createdTime", (dateAndTime[1] + " " + dateAndTime[2]));
			cmdToWriteMessageStatus.Parameters.AddWithValue("@howManyPeopleRead", 0);
			cmdToWriteMessageStatus.Parameters.AddWithValue("@deleted", 0);

			cmdToWriteMessageStatus.ExecuteNonQuery();

            return createdMessageId;
        }




		void DoSomethingWithLastRead(string userId, string conversationId, string messageId, string customerId, SqlConnection conn,
            string currentDateTime)
		{
			string sqlToCheckIfLastReadExists = @"SELECT TOP 1 id FROM tblMessageLastRead 
                WHERE ConversationId = @conversationId AND UserId=@userId";

			
			SqlCommand cmdToCheckIfLastReadExists = new SqlCommand(sqlToCheckIfLastReadExists, conn);
			cmdToCheckIfLastReadExists.Parameters.AddWithValue("@conversationId", conversationId);
			cmdToCheckIfLastReadExists.Parameters.AddWithValue("@userId", userId);

			SqlDataReader dt_toCheckIfLastReadExists = cmdToCheckIfLastReadExists.ExecuteReader();

			if (dt_toCheckIfLastReadExists.HasRows)
			{
				//  update
				UpdateLastReadMessage(userId, conversationId, messageId, customerId, conn, currentDateTime);
			}
			else
			{
				CreateLastReadMessage(userId, conversationId, messageId, customerId, conn, currentDateTime);
			}
		}



		void CreateLastReadMessage(string userId, string conversationId, string lastReadMessageId, string customerId, SqlConnection conn,
            string currentDateTime)
		{
			//  create
			string sqlCreateRecordForLastRead = @"INSERT INTO tblMessageLastRead (UserId, ConversationId, LastReadMessageId)
                                            VALUES (@userId, @conversationId, @lastReadMessageId)";
			
			SqlCommand cmdToCreateRecordForLastRead = new SqlCommand(sqlCreateRecordForLastRead, conn);


			cmdToCreateRecordForLastRead.Parameters.AddWithValue("@userId", userId);
			cmdToCreateRecordForLastRead.Parameters.AddWithValue("@conversationId", conversationId);
			cmdToCreateRecordForLastRead.Parameters.AddWithValue("@lastReadMessageId", lastReadMessageId);

			cmdToCreateRecordForLastRead.ExecuteNonQuery();
			WriteInfoAboutMessagesReadByEmployees(userId, conversationId, customerId, conn, currentDateTime);
		}



		void UpdateLastReadMessage(string userId, string conversationId, string lastReadMessageId, string customerId, SqlConnection conn,
            string currentDateTime)
		{
			string sqlUpdateRecordForLastRead = @"UPDATE tblMessageLastRead SET LastReadMessageId=@lastReadMessageId 
                    WHERE UserId=@userId AND ConversationId=@conversationId";
            
			SqlCommand cmdToUpdateRecordForLastRead = new SqlCommand(sqlUpdateRecordForLastRead, conn);
			cmdToUpdateRecordForLastRead.Parameters.AddWithValue("@lastReadMessageId", lastReadMessageId);
			cmdToUpdateRecordForLastRead.Parameters.AddWithValue("@userId", userId);
			cmdToUpdateRecordForLastRead.Parameters.AddWithValue("@conversationId", conversationId);

			cmdToUpdateRecordForLastRead.ExecuteNonQuery();

			WriteInfoAboutMessagesReadByEmployees(userId, conversationId, customerId, conn, currentDateTime);
		}



		void WriteInfoAboutMessagesReadByEmployees(string userId, string conversationId, string customerId, SqlConnection _conn,
            string currentDateTime)
		{

			string sqlToGetAllUnreadMessages = @"SELECT MessageId FROM tblMessage WHERE
                    ConversationId = @conversationId AND NOT AuthorId = @userId
	                AND NOT MessageId IN 
		(SELECT MessageId FROM tblMessagesReadByEmployees WHERE ConversationId = @conversationId AND UserId = @userId)";

			List<string> messagesIds_list = new List<string>();
            
			SqlCommand cmd = new SqlCommand(sqlToGetAllUnreadMessages, _conn);
			cmd.Parameters.AddWithValue("@conversationId", conversationId);
			cmd.Parameters.AddWithValue("@userId", userId);

			SqlDataReader dt = cmd.ExecuteReader();
			if (dt.HasRows)
			{
				while (dt.Read())
				{
					//Console.WriteLine(dt);
					for (int i = 0; i < dt.FieldCount; i++)
					{
						messagesIds_list.Add(dt[i].ToString());
					}
				}
			}
            
			foreach (string messageId in messagesIds_list)
			{
				//  update read messages
				string sqlToInsertMessagesReadByEmployees = @"INSERT INTO tblMessagesReadByEmployees 
                        (UserId, ConversationId, MessageId, MessageStatus, DateWhenRead, TimeWhenRead) 
                        VALUES 
                        (@employeeId, @conversationId, @messageId, @messageStatus, @dateWhenRead, @timeWhenRead);";

				var correctDateTime = currentDateTime;

				string[] dateAndTime = correctDateTime.ToString().Split(' ');
                
				SqlCommand cmdToInsertMessagesReadByEmployees = new SqlCommand(sqlToInsertMessagesReadByEmployees, _conn);

				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@employeeId", userId);
				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@conversationId", conversationId);

				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@messageId", messageId);
				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@messageStatus", 1);

				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@dateWhenRead", dateAndTime[0]);
				cmdToInsertMessagesReadByEmployees.Parameters.AddWithValue("@timeWhenRead", (dateAndTime[1] + " " + dateAndTime[2]));

				cmdToInsertMessagesReadByEmployees.ExecuteNonQuery();


                //  do shit here, too
                //  if exists - dont
                //  else insert

                string sqlToCheckIfInfoAboutReceivedMessagesExists = @"SELECT tblMessagesReceivedByEmployees.DateWhenReceived, 
                        tblMessagesReceivedByEmployees.TimeWhenReceived 
			            FROM tblMessagesReceivedByEmployees
	                    WHERE tblMessagesReceivedByEmployees.UserId = @userId 
			            AND tblMessagesReceivedByEmployees.ConversationId = @conversationId
			            AND tblMessagesReceivedByEmployees.MessageId = @messageId";

                SqlCommand cmdToCheckIfInfoAboutReceivedMessagesExists = new SqlCommand
                    (sqlToCheckIfInfoAboutReceivedMessagesExists, _conn);

                cmdToCheckIfInfoAboutReceivedMessagesExists.Parameters.AddWithValue("@userId", userId);
                cmdToCheckIfInfoAboutReceivedMessagesExists.Parameters.AddWithValue("@conversationId", conversationId);

                cmdToCheckIfInfoAboutReceivedMessagesExists.Parameters.AddWithValue("@messageId", messageId);

                SqlDataReader dt_toCheckIfInfoAboutReceivedMessagesExists = cmdToCheckIfInfoAboutReceivedMessagesExists.ExecuteReader();

                if (dt_toCheckIfInfoAboutReceivedMessagesExists.HasRows)
                {
                    //Console.WriteLine("Dont need to update");
                }
                else
                {

                    string sqlToSetReceivedMessageInfo = @"INSERT INTO tblMessagesReceivedByEmployees VALUES
                                                            (@userId, @conversationId, @messageId, @dateWhenReceived, @timeWhenReceived)";

                    SqlCommand cmdToToSetReceivedMessageInfo = new
                        SqlCommand(sqlToSetReceivedMessageInfo, _conn);
                    cmdToToSetReceivedMessageInfo.Parameters.AddWithValue("@userId", userId);
                    cmdToToSetReceivedMessageInfo.Parameters.AddWithValue("@conversationId", conversationId);
                    cmdToToSetReceivedMessageInfo.Parameters.AddWithValue("@messageId", messageId);
                    cmdToToSetReceivedMessageInfo.Parameters.
                        AddWithValue("@dateWhenReceived", dateAndTime[0]);
                    cmdToToSetReceivedMessageInfo.Parameters.
                        AddWithValue("@timeWhenReceived", (dateAndTime[1] + " " + dateAndTime[2]));
                    cmdToToSetReceivedMessageInfo.ExecuteNonQuery();
                }
            }
		}

		[HttpPost]
		[Route("api/message/getconversationparticipants")]
		public HttpResponseMessage GetConversationParticipants(ConversationIdClass cic_cl)
		{
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && cic_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (cic_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = cic_cl.userId;
                        customerId = cic_cl.customerId;
                        _Flib = ReturnConnectionObject(cic_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    string conversationId = cic_cl.conversationId;


                    string sqlToGetConversationParticipants = @"SELECT tblMessageConversationParticipants.conversationParticipantUserId, 
                            (tblUser.LastName + ' ' + tblUser.FirstName) AS userFullName, UserNo FROM tblMessageConversationParticipants
                            JOIN tblUser ON tblUser.UserId = tblMessageConversationParticipants.conversationParticipantUserId
                            WHERE tblMessageConversationParticipants.ConversationId = @conversationId AND NOT tblUser.UserId = @userId
                            ORDER BY tblUser.LastName ASC";


                    Dictionary<int, List<string>> listOfConversationParticipants = new Dictionary<int, List<string>>();

                    
                    SqlCommand cmdToGetConversationParticipants = new SqlCommand(sqlToGetConversationParticipants, conn);
                    cmdToGetConversationParticipants.Parameters.AddWithValue("@conversationId", conversationId);
                    cmdToGetConversationParticipants.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader dt_toGetConversationParticipants = cmdToGetConversationParticipants.ExecuteReader();

                    if (dt_toGetConversationParticipants.HasRows)
                    {
                        List<string> participantsIds = new List<string>();
                        int j = 0;
                        while (dt_toGetConversationParticipants.Read())
                        {
                            List<string> conversationParticipants = new List<string>();

                            string endResult = string.Empty;
                            for (int i = 0; i < dt_toGetConversationParticipants.FieldCount; i++)
                            {
                                conversationParticipants.Add(dt_toGetConversationParticipants[i].ToString());
                            }

                            listOfConversationParticipants.Add(j, conversationParticipants);

                            j++;
                        }
                    }


                    string sqlToGetConversationOwnerId = @"SELECT OwnerId FROM tblMessageConversation
                    WHERE ConversationId = @conversationId";
                    string conversationOwnerId = string.Empty;
                    
                    SqlCommand cmdToGetConversationOwnerId = new SqlCommand(sqlToGetConversationOwnerId, conn);
                    cmdToGetConversationOwnerId.Parameters.AddWithValue("@conversationId", conversationId);

                    conversationOwnerId = cmdToGetConversationOwnerId.ExecuteScalar().ToString();

                    bool youAreConversationAdmin = false;

                    if (conversationOwnerId == userId)
                    {
                        youAreConversationAdmin = true;
                    }

                    GetConversationParticipants_returnClass gcpRc_cl = new GetConversationParticipants_returnClass
                    {
                        listOfConversationParticipants = listOfConversationParticipants,
                        youAreConversationAdmin = youAreConversationAdmin
                    };

                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(gcpRc_cl));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		[HttpPost]
		[Route("api/message/getinfoaboutreadmessages")]
		public HttpResponseMessage GetInfoAboutReadMessages(MessageIdInput mii_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && mii_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    if (mii_cl.webVersion == true)
                    {
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        _Flib = ReturnConnectionObject(mii_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    int messageId = mii_cl.messageId;

                    Dictionary<string, string> idToName_dict = new Dictionary<string, string>();

                    Dictionary<string, List<string>> PeopleWhoReadMessage_dict = new Dictionary<string, List<string>>();

                    string sqlToGetInfoAboutReadMessages = @"SELECT tblUser.UserId, 
                                (tblUser.FirstName + ' ' + tblUser.LastName) AS userFullName,
	                            tblMessagesReadByEmployees.DateWhenRead, tblMessagesReadByEmployees.TimeWhenRead FROM tblUser
	                            JOIN tblMessagesReadByEmployees ON tblUser.UserId = tblMessagesReadByEmployees.UserId
	                            WHERE tblMessagesReadByEmployees.MessageId = @messageId";


                    
                    SqlCommand cmdToGetInfoAboutReadMessages = new SqlCommand(sqlToGetInfoAboutReadMessages, conn);
                    cmdToGetInfoAboutReadMessages.Parameters.AddWithValue("@messageId", messageId);

                    SqlDataReader dt_toGetInfoAboutReadMessages = cmdToGetInfoAboutReadMessages.ExecuteReader();

                    if (dt_toGetInfoAboutReadMessages.HasRows)
                    {
                        while (dt_toGetInfoAboutReadMessages.Read())
                        {
                            List<string> readMessageInfo = new List<string>();

                            string endResult = string.Empty;

                            string userId = dt_toGetInfoAboutReadMessages[0].ToString ();
                            string userName = dt_toGetInfoAboutReadMessages[1].ToString();

                            if (!idToName_dict.ContainsKey(userId))
                            {
                                idToName_dict[userId] = userName;
                            }

                            for (int i = 2; i < dt_toGetInfoAboutReadMessages.FieldCount; i++)
                            {
                                var value = dt_toGetInfoAboutReadMessages[i].ToString();
                                if (value.Contains(" 12:00:00 AM"))
                                {
                                    value = value.Replace(" 12:00:00 AM", "");
                                }
                                readMessageInfo.Add(value);
                            }
                            if (!PeopleWhoReadMessage_dict.ContainsKey(userId))
                            {
                                PeopleWhoReadMessage_dict.Add(userId, readMessageInfo);
                            }
                            
                        }
                    }


                    string sqlToGetInfoAboutReceivedMessages = @"SELECT tblUser.UserId, (tblUser.FirstName + ' ' + tblUser.LastName) 
                        AS userFullName, tblMessagesReceivedByEmployees.DateWhenReceived, tblMessagesReceivedByEmployees.TimeWhenReceived
			            FROM tblUser
	                    JOIN tblMessagesReceivedByEmployees ON tblUser.UserId = tblMessagesReceivedByEmployees.UserId
	                    WHERE tblMessagesReceivedByEmployees.MessageId = @messageId";

                    Dictionary<string, List<string>> PeopleWhoReceivedMessage_dict = new Dictionary<string, List<string>>();

                    SqlCommand cmdToGetInfoAboutReceivedMessages = new SqlCommand(sqlToGetInfoAboutReceivedMessages, conn);
                    cmdToGetInfoAboutReceivedMessages.Parameters.AddWithValue("@messageId", messageId);

                    SqlDataReader dt_toGetInfoAboutReceivedMessages = cmdToGetInfoAboutReceivedMessages.ExecuteReader();
                    
                    if (dt_toGetInfoAboutReceivedMessages.HasRows)
                    {
                        while (dt_toGetInfoAboutReceivedMessages.Read())
                        {
                            List<string> readMessageInfo = new List<string>();

                            string endResult = string.Empty;

                            string userId = dt_toGetInfoAboutReceivedMessages[0].ToString();
                            string userName = dt_toGetInfoAboutReceivedMessages[1].ToString();

                            if (!idToName_dict.ContainsKey(userId))
                            {
                                idToName_dict[userId] = userName;
                            }
                            for (int i = 2; i < dt_toGetInfoAboutReceivedMessages.FieldCount; i++)
                            {
                                var value = dt_toGetInfoAboutReceivedMessages[i].ToString();
                                if (value.Contains(" 12:00:00 AM"))
                                {
                                    value = value.Replace(" 12:00:00 AM", "");
                                }
                                readMessageInfo.Add(value);
                            }
                            if (!PeopleWhoReceivedMessage_dict.ContainsKey (userId))
                            {
                                PeopleWhoReceivedMessage_dict.Add(userId, readMessageInfo);
                            }

                        }
                    }
                    

                    //List<string> userIdsMentioned = new List<string>();

                    List<string> userIdsMessagesRead = PeopleWhoReadMessage_dict.Keys.ToList ();
                    List<string> userIdsMessagesReceived = PeopleWhoReceivedMessage_dict.Keys.ToList ();

                    List<string> userIdsMentioned_list = userIdsMessagesRead.Union(userIdsMessagesReceived).ToList ();

                    //Console.WriteLine(userIdsMentioned_list);

                    Dictionary<string, List<string>> finalInfoAboutMessage_dict = new Dictionary<string, List<string>>();

                    GetInfoAboutReadMessages_returnClass giarmRc_cl = new GetInfoAboutReadMessages_returnClass();
                    if (userIdsMentioned_list.Count > 0)
                    {
                        giarmRc_cl.thereIsAnyInfoAboutMessage = true;

                        foreach (string userIdInAction in userIdsMentioned_list)
                        {
                            List<string> infoAboutWhatUserDidWithMessage_list = new List<string>();

                            infoAboutWhatUserDidWithMessage_list.Add(idToName_dict[userIdInAction]);

                            if (PeopleWhoReceivedMessage_dict.ContainsKey (userIdInAction))
                            {
                                infoAboutWhatUserDidWithMessage_list.AddRange(PeopleWhoReceivedMessage_dict [userIdInAction]);
                            }
                            else
                            {
                                infoAboutWhatUserDidWithMessage_list.Add("");
                                infoAboutWhatUserDidWithMessage_list.Add("");
                            }

                            if (PeopleWhoReadMessage_dict.ContainsKey(userIdInAction))
                            {
                                infoAboutWhatUserDidWithMessage_list.AddRange(PeopleWhoReadMessage_dict[userIdInAction]);
                            }
                            else
                            {
                                infoAboutWhatUserDidWithMessage_list.Add("");
                                infoAboutWhatUserDidWithMessage_list.Add("");
                            }

                            finalInfoAboutMessage_dict[userIdInAction] = infoAboutWhatUserDidWithMessage_list;
                        }

                        giarmRc_cl.listOfInfoAboutMessage = finalInfoAboutMessage_dict;
                    }
                    else
                    {
                        giarmRc_cl.thereIsAnyInfoAboutMessage = false;
                    }

                    //Console.WriteLine(finalInfoAboutMessage_dict);

                    //GetInfoAboutReadMessages_returnClass giarmRc_cl = new GetInfoAboutReadMessages_returnClass
                    //{
                    //    listOfPeopleWhoReadMessage = PeopleWhoReadMessage_dict
                    //};

                    //if (userIdsMentioned_list.Count > 0)
                    //{
                    //    giarmRc_cl.messageWasAtLeastRead = true;
                    //}
                    //else
                    //{
                    //    giarmRc_cl.messageWasAtLeastRead = false;
                    //}


                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(giarmRc_cl));
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		[HttpPost]
		[Route("api/message/removeparticipantfromconversation")]
		public HttpResponseMessage RemoveParticipantFromConversation(ActionsHappeningWithParticipant ahwp_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && ahwp_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    if (ahwp_cl.webVersion == true)
                    {
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        _Flib = ReturnConnectionObject(ahwp_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    int conversationId = ahwp_cl.conversationId;
                    List<int> participantIds = ahwp_cl.participantIds;

                    foreach (int participantId in participantIds)
                    {
                        string sqlToRemoveParticipantFromConversation = @"DELETE FROM tblMessageConversationParticipants
                            WHERE ConversationId=@conversationId AND ConversationParticipantUserId=@participantId;";

                        
                        SqlCommand cmdToRemoveParticipantFromConversation = new SqlCommand(sqlToRemoveParticipantFromConversation, conn);
                        cmdToRemoveParticipantFromConversation.Parameters.AddWithValue("@conversationId", conversationId);
                        cmdToRemoveParticipantFromConversation.Parameters.AddWithValue("@participantId", participantId);

                        cmdToRemoveParticipantFromConversation.ExecuteNonQuery();
                        
                    }

                    //  update
                    string sqlToUpdateNumberOfParticipants = @"UPDATE tblMessageConversation SET ConversationNumberOfParticipants=
                    (SELECT tblMessageConversation.ConversationNumberOfParticipants - 1 FROM tblMessageConversation
	                    WHERE ConversationId = @ConversationId) 
                    WHERE ConversationId=@ConversationId";

                    
                    SqlCommand cmdToUpdateNumberOfParticipants = new SqlCommand(sqlToUpdateNumberOfParticipants, conn);
                    cmdToUpdateNumberOfParticipants.Parameters.AddWithValue("@ConversationId", conversationId);

                    cmdToUpdateNumberOfParticipants.ExecuteNonQuery();


                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		[HttpPost]
		[Route("api/message/checkifconversationexistswithsuchusers")]
		public HttpResponseMessage CheckIfConversationExistsWithSuchUsers(CheckIfConvExists cice_cl)
        {
            Console.WriteLine("aa");
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && cice_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    string[] userIdsInConversation = cice_cl.userIdsInConversation;


                    List<string> userIdsInConversation_list = userIdsInConversation.ToList();
                    int numberOfPeopleInConversation = userIdsInConversation_list.Count;

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (cice_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = cice_cl.userId;
                        customerId = cice_cl.customerId;
                        _Flib = ReturnConnectionObject(cice_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    //  just making sure. Pay attention to the adding people to an existing conversation

                    if (!userIdsInConversation_list.Contains(userId))
                    {
                        userIdsInConversation_list.Add(userId);
                        numberOfPeopleInConversation = userIdsInConversation_list.Count;
                    }

                    string userIdsForConvo = string.Join(",", userIdsInConversation_list.ToArray());

                    string sqlToCheckIfConversationWithSuchPeopleExist = String.Format (@"SELECT  a.*
		                FROM    tblMessageConversation a
                        INNER JOIN
                        (
                            SELECT  ConversationId
                            FROM    tblMessageConversationParticipants 
                            WHERE   ConversationParticipantUserId IN ({0})
                            GROUP   BY ConversationId
                            HAVING  COUNT(*) = @userIdsForConvoLength
                        ) b ON a.ConversationId = b.ConversationId
		                WHERE a.ConversationNumberOfParticipants = @userIdsForConvoLength", userIdsForConvo);

                    SqlCommand cmdToGetMatchingConversations =
                        new SqlCommand(sqlToCheckIfConversationWithSuchPeopleExist, conn);
                    //cmdToGetMatchingConversations.Parameters.
                    //    AddWithValue("@userIdsForConvo", userIdsForConvo);
                    cmdToGetMatchingConversations.Parameters.
                        AddWithValue("@userIdsForConvoLength", userIdsInConversation_list.Count);

                    //string possibleConvo = cmdToGetMatchingConversations.ExecuteScalar().ToString ();


                    SqlDataReader nah =
                        cmdToGetMatchingConversations.ExecuteReader();

                    if (nah.HasRows)
                    {
                        string neededConversationId = string.Empty;
                        string conversationName = string.Empty;
                        while (nah.Read())
                        {
                            neededConversationId = nah[0].ToString();
                            conversationName = nah[2].ToString();
                        }

                        CheckIfConvExistsReturnClass cicerc_cl = new CheckIfConvExistsReturnClass
                        {
                            success = true,
                            conversationId = neededConversationId,
                            conversationName = conversationName
                        };
                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(cicerc_cl));
                    }
                    else
                    {

                        CheckIfConvExistsReturnClass cicerc_cl1 = new CheckIfConvExistsReturnClass
                        {
                            success = false,
                            conversationId = ""
                        };
                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(cicerc_cl1));
                    }


             //       string sqlToGetConversationIdsWithNeededNumberOfParticipants = @"SELECT tblMessageConversation.ConversationId FROM tblMessageConversation WHERE
	            //tblMessageConversation.ConversationNumberOfParticipants = @numberOfPeopleInConversation";

             //       //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


                    
             //       SqlCommand cmdToGetConversationIdsWithNeededNumberOfParticipants =
             //           new SqlCommand(sqlToGetConversationIdsWithNeededNumberOfParticipants, conn);
             //       cmdToGetConversationIdsWithNeededNumberOfParticipants.Parameters.
             //           AddWithValue("@numberOfPeopleInConversation", numberOfPeopleInConversation);

             //       SqlDataReader dt_toGetConversationIdsWithNeededNumberOfParticipants =
             //           cmdToGetConversationIdsWithNeededNumberOfParticipants.ExecuteReader();

                    //if (dt_toGetConversationIdsWithNeededNumberOfParticipants.HasRows)
                    //{
                    //    List<string> possibleConversationIds_list = new List<string>();
                    //    while (dt_toGetConversationIdsWithNeededNumberOfParticipants.Read())
                    //    {
                    //        for (int i = 0; i < dt_toGetConversationIdsWithNeededNumberOfParticipants.FieldCount; i++)
                    //        {
                    //            possibleConversationIds_list.Add(dt_toGetConversationIdsWithNeededNumberOfParticipants[i].ToString());
                    //        }
                    //    }

                    //    Dictionary<string, List<string>> conversationIdtoParticipantsIds_dict = new Dictionary<string, List<string>>();

                    //    foreach (string conversationId in possibleConversationIds_list)
                    //    {
                    //        string sqlToGetParticipantIdsFromConversation = @"SELECT tblMessageConversationParticipants.ConversationParticipantUserId 
                    //    FROM tblMessageConversationParticipants
	                   // WHERE tblMessageConversationParticipants.ConversationId = @conversationId";
                            
                    //        SqlCommand cmdToGetConversationParticipants = new SqlCommand(sqlToGetParticipantIdsFromConversation, conn);
                    //        cmdToGetConversationParticipants.Parameters.AddWithValue("@conversationId", conversationId);

                    //        SqlDataReader dt_toGetConversationParticipants = cmdToGetConversationParticipants.ExecuteReader();

                    //        if (dt_toGetConversationParticipants.HasRows)
                    //        {
                    //            List<string> participantsIds = new List<string>();
                    //            while (dt_toGetConversationParticipants.Read())
                    //            {
                    //                for (int i = 0; i < dt_toGetConversationParticipants.FieldCount; i++)
                    //                {
                    //                    participantsIds.Add(dt_toGetConversationParticipants[i].ToString());
                    //                }
                    //                conversationIdtoParticipantsIds_dict[conversationId] = participantsIds;
                    //            }
                    //        }
                    //    }

                    //    bool neededConversationFound_bool = false;
                    //    string neededConversationId = string.Empty;

                    //    foreach (KeyValuePair<string, List<string>> kvp in conversationIdtoParticipantsIds_dict)
                    //    {
                    //        neededConversationFound_bool = ScrambledEquals(userIdsInConversation_list, kvp.Value);
                    //        if (neededConversationFound_bool == true)
                    //        {
                    //            neededConversationId = kvp.Key;
                    //            break;
                    //        }
                    //    }

                    //    if (neededConversationFound_bool == true)
                    //    {
                    //        string sqlToGetConversationName = @"SELECT ConversationName FROM 
                    //                            tblMessageConversation WHERE 
                    //                            tblMessageConversation.ConversationId = @conversationId";

                    //        string conversationName = string.Empty;
                    //        SqlCommand cmdToGetConversationName = new SqlCommand(sqlToGetConversationName, conn);
                    //        cmdToGetConversationName.Parameters.AddWithValue("@conversationId", neededConversationId);

                    //        conversationName = cmdToGetConversationName.ExecuteScalar().ToString().TrimEnd();

                    //        CheckIfConvExistsReturnClass cicerc_cl = new CheckIfConvExistsReturnClass
                    //        {
                    //            success = true,
                    //            conversationId = neededConversationId,
                    //            conversationName = conversationName
                    //        };
                    //        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(cicerc_cl));

                    //    }
                    //    else
                    //    {
                    //        CheckIfConvExistsReturnClass cicerc_cl = new CheckIfConvExistsReturnClass
                    //        {
                    //            success = false,
                    //            conversationId = ""
                    //        };
                    //        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(cicerc_cl));
                    //    }

                    //}
                    //else
                    //{
                    //    CheckIfConvExistsReturnClass cicerc_cl = new CheckIfConvExistsReturnClass
                    //    {
                    //        success = false,
                    //        conversationId = ""
                    //    };
                    //    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(cicerc_cl));
                    //}
                    
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


        [HttpPost]
        [Route("api/message/gettingnumberofunreadmessagesforstatus")]
        public HttpResponseMessage GettingNumberOfUnreadMessagesForStatus(UniversalOnlyForWebVersion uofwv_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            
            bool thereAreUnreadMessages = false;

            try
            {
                if (HttpContext.Current.Session["company_name"] == null && uofwv_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (uofwv_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = uofwv_cl.userId;
                        customerId = uofwv_cl.customerId;
                        _Flib = ReturnConnectionObject(uofwv_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    string sqlToGetConversationIds = @"SELECT ConversationId FROM tblMessageConversationParticipants 
                                    WHERE ConversationParticipantUserId = @userId";

                    List<string> availableConversationIds_list = new List<string>();
                    List<AvailableConversations> availableConversations_list = new List<AvailableConversations>();

                    List<string> allConversationUserParticipatesIn = new List<string>();

                    using (SqlCommand cmdToGetConversationIds = new SqlCommand(sqlToGetConversationIds, conn))
                    {
                        cmdToGetConversationIds.Parameters.AddWithValue("@userId", userId);
                        using (SqlDataReader dt_toGetcmdToGetConversationIds = cmdToGetConversationIds.ExecuteReader())
                        {
                            if (dt_toGetcmdToGetConversationIds.HasRows)
                            {
                                while (dt_toGetcmdToGetConversationIds.Read())
                                {

                                    string conversationId = dt_toGetcmdToGetConversationIds[0].ToString();
                                    allConversationUserParticipatesIn.Add(conversationId);
                                }
                            }
                        }
                    }

                    List<string> conversationsWhereThereAreUnreadMessages_list = new List<string>();

                    if (allConversationUserParticipatesIn.Count > 0)
                    {
                        foreach (string conversationId in allConversationUserParticipatesIn)
                        {
                            string sqlToGetMessagesYouDidntReadFromConvo = @"SELECT COUNT (tblMessage.MessageId) AS 'NumberOfUnreadMessages' FROM tblMessage
	                            JOIN tblMessageStatus ON tblMessageStatus.MessageId = tblMessage.MessageId
		                        WHERE tblMessageStatus.Deleted = 0 AND tblMessage.ConversationId = @conversationId
                                    AND NOT tblMessage.AuthorId = @userId
	                            AND tblMessage.MessageId > 
		                        (
		                        SELECT CASE 
			                        WHEN (SELECT MAX (tblMessagesReadByEmployees.MessageId) 
			                        FROM tblMessagesReadByEmployees WHERE tblMessagesReadByEmployees.ConversationId = @conversationId) IS NULL
		                        THEN 0
		                        ELSE
			                        (SELECT MAX (tblMessagesReadByEmployees.MessageId) 
			                        FROM tblMessagesReadByEmployees WHERE tblMessagesReadByEmployees.ConversationId = @conversationId)
		                        END
		                        );SELECT SCOPE_IDENTITY();";

                            List<string> unreadMessages = new List<string>();

                            SqlCommand cmd = new SqlCommand(sqlToGetMessagesYouDidntReadFromConvo, conn);
                            cmd.Parameters.AddWithValue("@conversationId", conversationId);
                            cmd.Parameters.AddWithValue("@userId", userId);

                            //SqlDataReader dt = cmd.ExecuteReader();
                            int numberOfUnreadMessages = Convert.ToInt32((cmd.ExecuteScalar().ToString()));
                            if (numberOfUnreadMessages > 0)
                            {
                                thereAreUnreadMessages = true;
                                break;
                            }
                        }
                        
                        if (thereAreUnreadMessages == true)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, true);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, false);
                        }
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, false);
                    }
                    
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
        }




        [HttpPost]
		[Route("api/message/addparticipantsinconversation")]
		public HttpResponseMessage AddParticipantsInConversation(AddParticipantsInConversationInput apici_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && apici_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {

                    string[] userIdsInConversation = apici_cl.userIdsInConversation;

                    string userId = string.Empty;
                    string customerId = string.Empty;

                    if (apici_cl.webVersion == true)
                    {
                        userId = ReturnUserId();
                        customerId = ReturnCustomerId();
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        userId = apici_cl.userId;
                        customerId = apici_cl.customerId;
                        _Flib = ReturnConnectionObject(apici_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    List<string> userIdsInConversation_list = userIdsInConversation.ToList();
                    if (!userIdsInConversation_list.Contains(userId))
                    {
                        userIdsInConversation_list.Add(userId);
                    }

                    string conversationId = apici_cl.conversationId;
                    string conversationName = apici_cl.conversationName;
                    //  string[] userIdsInConversation, string conversationId, string conversationName
                    //  this one should go to CONVERSATION description
                    int numberOfPeopleInConversation = userIdsInConversation_list.Count;
                    string sqlToTellHowManyParticipants = "";

                    if (conversationName == "")
                    {
                        sqlToTellHowManyParticipants = @"UPDATE tblMessageConversation 
                            SET ConversationNumberOfParticipants=@ConversationNumberOfParticipants 
                            WHERE ConversationId=@ConversationId";
                    }
                    else
                    {
                        sqlToTellHowManyParticipants = @"UPDATE tblMessageConversation 
                            SET ConversationNumberOfParticipants=@ConversationNumberOfParticipants,
                            ConversationName=@conversationName WHERE ConversationId=@ConversationId";
                    }

                    
                    SqlCommand cmdToTellHowManyParticipants = new SqlCommand(sqlToTellHowManyParticipants, conn);
                    cmdToTellHowManyParticipants.Parameters.AddWithValue("@ConversationNumberOfParticipants", numberOfPeopleInConversation);
                    cmdToTellHowManyParticipants.Parameters.AddWithValue("@ConversationId", conversationId);
                    if (conversationName != "")
                    {
                        cmdToTellHowManyParticipants.Parameters.AddWithValue("@conversationName", conversationName);
                    }

                    cmdToTellHowManyParticipants.ExecuteNonQuery();

                    RegisterParticipantsInConversation(userIdsInConversation_list.ToArray(), conversationId, conn);


                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}


		[HttpPost]
		[Route("api/message/addingparticipantsinexistingconversation")]
		public HttpResponseMessage AddingParticipantsInExistingConversation(ActionsHappeningWithParticipant ahwp_cl)
        {
            SqlConnection conn = new SqlConnection();
            Functionlib _Flib;
            try
            {
                if (HttpContext.Current.Session["company_name"] == null && ahwp_cl.webVersion == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "");
                }
                else
                {
                    if (ahwp_cl.webVersion == true)
                    {
                        _Flib = ReturnConnectionObject("", true);
                    }
                    else
                    {
                        _Flib = ReturnConnectionObject(ahwp_cl.ConnectionId, false);
                    }
                    conn = _Flib.getConnection();

                    //  insert
                    List<int> newlyAddedConversationParticipants = ahwp_cl.participantIds;
                    int conversationId = ahwp_cl.conversationId;
                    int newNumberOfHowManyParticipantsInConversation = ahwp_cl.newNumberOfConversationParticipants;

                    foreach (int newParticipantId in newlyAddedConversationParticipants)
                    {
                        string sqlToAddParticipantsInExistingConversation = @"INSERT INTO tblMessageConversationParticipants VALUES
                (@conversationId, @participantId)";
                        
                        SqlCommand cmdToAddParticipantsInExistingConversation = new SqlCommand(sqlToAddParticipantsInExistingConversation,
                            conn);
                        cmdToAddParticipantsInExistingConversation.Parameters.AddWithValue("@conversationId", conversationId);
                        cmdToAddParticipantsInExistingConversation.Parameters.AddWithValue("@participantId", newParticipantId);

                        cmdToAddParticipantsInExistingConversation.ExecuteNonQuery();
                    }

                    //  update
                    string sqlToUpdateNumberOfParticipants = @"UPDATE tblMessageConversation 
                            SET ConversationNumberOfParticipants=@ConversationNumberOfParticipants 
                            WHERE ConversationId=@ConversationId";

                    
                    SqlCommand cmdToUpdateNumberOfParticipants = new SqlCommand(sqlToUpdateNumberOfParticipants, conn);
                    cmdToUpdateNumberOfParticipants.Parameters.AddWithValue("@ConversationNumberOfParticipants", 
                        newNumberOfHowManyParticipantsInConversation);
                    cmdToUpdateNumberOfParticipants.Parameters.AddWithValue("@ConversationId", conversationId);

                    cmdToUpdateNumberOfParticipants.ExecuteNonQuery();


                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            finally
            {
                conn.Close();
            }
		}



		public void RegisterParticipantsInConversation(string[] userIdsInConversation, string conversationId, SqlConnection conn)
		{
			//var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
			List<string> userIdsInConversation_list = userIdsInConversation.ToList();

            
            foreach (string userId in userIdsInConversation_list)
            {
                string sqlToInsertParticipants = @"INSERT INTO tblMessageConversationParticipants (ConversationId, ConversationParticipantUserId) 
                    VALUES (@messageConversationId, @messageConversationParticipant)";

                SqlCommand cmdToInsertParticipants = new SqlCommand(sqlToInsertParticipants, conn);
                cmdToInsertParticipants.Parameters.AddWithValue("@messageConversationId", conversationId);
                cmdToInsertParticipants.Parameters.AddWithValue("@messageConversationParticipant", userId);

                cmdToInsertParticipants.ExecuteNonQuery();

            }
            
			
		}





		public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
		{
			var cnt = new Dictionary<T, int>();
			foreach (T s in list1)
			{
				if (cnt.ContainsKey(s))
				{
					cnt[s]++;
				}
				else
				{
					cnt.Add(s, 1);
				}
			}
			foreach (T s in list2)
			{
				if (cnt.ContainsKey(s))
				{
					cnt[s]--;
				}
				else
				{
					return false;
				}
			}
			return cnt.Values.All(c => c == 0);
		}
	}
}