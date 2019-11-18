using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class ReturnOrderInfoHelper : TBeanSerializer<ReturnOrderInfo>
	{
		
		public static ReturnOrderInfoHelper OBJ = new ReturnOrderInfoHelper();
		
		public static ReturnOrderInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ReturnOrderInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("custName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustName(value);
					}
					
					
					
					
					
					if ("returnStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnStatus(value);
					}
					
					
					
					
					
					if ("appointmentReturnTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAppointmentReturnTime(value);
					}
					
					
					
					
					
					if ("overReturnTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOverReturnTime(value);
					}
					
					
					
					
					
					if ("actualReturnTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActualReturnTime(value);
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
		
		
		public void Write(ReturnOrderInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustName() != null) {
				
				oprot.WriteFieldBegin("custName");
				oprot.WriteString(structs.GetCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnStatus() != null) {
				
				oprot.WriteFieldBegin("returnStatus");
				oprot.WriteString(structs.GetReturnStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAppointmentReturnTime() != null) {
				
				oprot.WriteFieldBegin("appointmentReturnTime");
				oprot.WriteString(structs.GetAppointmentReturnTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOverReturnTime() != null) {
				
				oprot.WriteFieldBegin("overReturnTime");
				oprot.WriteString(structs.GetOverReturnTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActualReturnTime() != null) {
				
				oprot.WriteFieldBegin("actualReturnTime");
				oprot.WriteString(structs.GetActualReturnTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ReturnOrderInfo bean){
			
			
		}
		
	}
	
}