using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class WorkOrderQueryReqHelper : TBeanSerializer<WorkOrderQueryReq>
	{
		
		public static WorkOrderQueryReqHelper OBJ = new WorkOrderQueryReqHelper();
		
		public static WorkOrderQueryReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WorkOrderQueryReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("distribute_start_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetDistribute_start_time(value);
					}
					
					
					
					
					
					if ("distribute_end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetDistribute_end_time(value);
					}
					
					
					
					
					
					if ("work_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWork_order_no(value);
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
		
		
		public void Write(WorkOrderQueryReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrier_code can not be null!");
			}
			
			
			if(structs.GetDistribute_start_time() != null) {
				
				oprot.WriteFieldBegin("distribute_start_time");
				oprot.WriteI64((long)structs.GetDistribute_start_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistribute_end_time() != null) {
				
				oprot.WriteFieldBegin("distribute_end_time");
				oprot.WriteI64((long)structs.GetDistribute_end_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWork_order_no() != null) {
				
				oprot.WriteFieldBegin("work_order_no");
				oprot.WriteString(structs.GetWork_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WorkOrderQueryReq bean){
			
			
		}
		
	}
	
}