using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class OrderQueryModelHelper : TBeanSerializer<OrderQueryModel>
	{
		
		public static OrderQueryModelHelper OBJ = new OrderQueryModelHelper();
		
		public static OrderQueryModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderQueryModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("orderTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderTimeStart(value);
					}
					
					
					
					
					
					if ("orderTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderTimeEnd(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("requestId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequestId(value);
					}
					
					
					
					
					
					if ("updateTimeStart".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTimeStart(value);
					}
					
					
					
					
					
					if ("updateTimeEnd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTimeEnd(value);
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
		
		
		public void Write(OrderQueryModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI16((short)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderTimeStart() != null) {
				
				oprot.WriteFieldBegin("orderTimeStart");
				oprot.WriteI64((long)structs.GetOrderTimeStart()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderTimeEnd() != null) {
				
				oprot.WriteFieldBegin("orderTimeEnd");
				oprot.WriteI64((long)structs.GetOrderTimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestId() != null) {
				
				oprot.WriteFieldBegin("requestId");
				oprot.WriteString(structs.GetRequestId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestId can not be null!");
			}
			
			
			if(structs.GetUpdateTimeStart() != null) {
				
				oprot.WriteFieldBegin("updateTimeStart");
				oprot.WriteI64((long)structs.GetUpdateTimeStart()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTimeEnd() != null) {
				
				oprot.WriteFieldBegin("updateTimeEnd");
				oprot.WriteI64((long)structs.GetUpdateTimeEnd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderQueryModel bean){
			
			
		}
		
	}
	
}