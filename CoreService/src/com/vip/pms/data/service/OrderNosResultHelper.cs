using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OrderNosResultHelper : TBeanSerializer<OrderNosResult>
	{
		
		public static OrderNosResultHelper OBJ = new OrderNosResultHelper();
		
		public static OrderNosResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderNosResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("orderNos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderNos(value);
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
		
		
		public void Write(OrderNosResult structs, Protocol oprot){
			
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
			
			
			if(structs.GetOrderNos() != null) {
				
				oprot.WriteFieldBegin("orderNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetOrderNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderNos can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderNosResult bean){
			
			
		}
		
	}
	
}