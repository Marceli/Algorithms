using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using NUnit.Framework;
using System.ServiceModel.MsmqIntegration;
using System.Transactions;

namespace Algorithms
{

	public class OrderProcessorClient:ClientBase<IOrderProcessor>,IOrderProcessor
	{
		public OrderProcessorClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public void SendMessage(MsmqMessage<string> msg)
		{

			base.Channel.SendMessage(msg);
			
		}
	}
	[ServiceContractAttribute]
	public interface IOrderProcessor
	{
		[OperationContract(IsOneWay = true, Action = "*")]
		void SendMessage(MsmqMessage<string> msg);
	}

	[TestFixture]
	public class MSMQTest
	{
		private string queuName = @".\private$\olo";
		[Test]
		public void WriteToQueue()
		{
			//var address =new EndpointAddress(@"msmq.formatname:DIRECT=OS:.\private$\olo");
			var address =new EndpointAddress(@"msmq.formatname:.\private$\olo");
			MsmqIntegrationBinding binding = new MsmqIntegrationBinding();
			using (var processor = new OrderProcessorClient(binding, address))
			{

				using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
				{
					processor.SendMessage(new MsmqMessage<string>("JurasBuras2"));
					scope.Complete();
				}
			}


		}
	}
}
