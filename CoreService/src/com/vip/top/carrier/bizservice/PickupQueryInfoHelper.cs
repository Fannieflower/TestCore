using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class PickupQueryInfoHelper : TBeanSerializer<PickupQueryInfo>
	{
		
		public static PickupQueryInfoHelper OBJ = new PickupQueryInfoHelper();
		
		public static PickupQueryInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PickupQueryInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("pointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPointName(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("opName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpName(value);
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
		
		
		public void Write(PickupQueryInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPointName() != null) {
				
				oprot.WriteFieldBegin("pointName");
				oprot.WriteString(structs.GetPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteString(structs.GetBeginTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteString(structs.GetEndTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpName() != null) {
				
				oprot.WriteFieldBegin("opName");
				oprot.WriteString(structs.GetOpName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PickupQueryInfo bean){
			
			
		}
		
	}
	
}