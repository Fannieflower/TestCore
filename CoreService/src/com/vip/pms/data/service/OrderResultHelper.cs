using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OrderResultHelper : TBeanSerializer<OrderResult>
	{
		
		public static OrderResultHelper OBJ = new OrderResultHelper();
		
		public static OrderResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("errorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetErrorCode(value);
					}
					
					
					
					
					
					if ("errorMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorMessage(value);
					}
					
					
					
					
					
					if ("ordermids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.Ordermid> value;
						
						value = new List<com.vip.pms.data.service.Ordermid>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.Ordermid elem1;
								
								elem1 = new com.vip.pms.data.service.Ordermid();
								com.vip.pms.data.service.OrdermidHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrdermids(value);
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
		
		
		public void Write(OrderResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetErrorCode() != null) {
				
				oprot.WriteFieldBegin("errorCode");
				oprot.WriteI32((int)structs.GetErrorCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorMessage() != null) {
				
				oprot.WriteFieldBegin("errorMessage");
				oprot.WriteString(structs.GetErrorMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrdermids() != null) {
				
				oprot.WriteFieldBegin("ordermids");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.Ordermid _item0 in structs.GetOrdermids()){
					
					
					com.vip.pms.data.service.OrdermidHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ordermids can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderResult bean){
			
			
		}
		
	}
	
}