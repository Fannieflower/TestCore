using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class QueryTransferringDeliveryResultHelper : TBeanSerializer<QueryTransferringDeliveryResult>
	{
		
		public static QueryTransferringDeliveryResultHelper OBJ = new QueryTransferringDeliveryResultHelper();
		
		public static QueryTransferringDeliveryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryTransferringDeliveryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList();
								vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryListHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTransferring_orders(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(QueryTransferringDeliveryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_orders() != null) {
				
				oprot.WriteFieldBegin("transferring_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryList _item0 in structs.GetTransferring_orders()){
					
					
					vipapis.xstore.cc.transferring.api.TransferringOrderDeliveryListHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryTransferringDeliveryResult bean){
			
			
		}
		
	}
	
}