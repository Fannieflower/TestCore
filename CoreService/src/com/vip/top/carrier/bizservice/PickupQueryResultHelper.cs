using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class PickupQueryResultHelper : TBeanSerializer<PickupQueryResult>
	{
		
		public static PickupQueryResultHelper OBJ = new PickupQueryResultHelper();
		
		public static PickupQueryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PickupQueryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetQty(value);
					}
					
					
					
					
					
					if ("joinTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetJoinTime(value);
					}
					
					
					
					
					
					if ("opName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpName(value);
					}
					
					
					
					
					
					if ("pointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPointName(value);
					}
					
					
					
					
					
					if ("customerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerName(value);
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
		
		
		public void Write(PickupQueryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQty() != null) {
				
				oprot.WriteFieldBegin("qty");
				oprot.WriteI32((int)structs.GetQty()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetJoinTime() != null) {
				
				oprot.WriteFieldBegin("joinTime");
				oprot.WriteString(structs.GetJoinTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpName() != null) {
				
				oprot.WriteFieldBegin("opName");
				oprot.WriteString(structs.GetOpName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPointName() != null) {
				
				oprot.WriteFieldBegin("pointName");
				oprot.WriteString(structs.GetPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerName() != null) {
				
				oprot.WriteFieldBegin("customerName");
				oprot.WriteString(structs.GetCustomerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PickupQueryResult bean){
			
			
		}
		
	}
	
}