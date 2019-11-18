using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class WorkOrderProcessResultHelper : TBeanSerializer<WorkOrderProcessResult>
	{
		
		public static WorkOrderProcessResultHelper OBJ = new WorkOrderProcessResultHelper();
		
		public static WorkOrderProcessResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WorkOrderProcessResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("rely_content".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.wo.RelyContent value;
						
						value = new com.vip.vop.logistics.wo.RelyContent();
						com.vip.vop.logistics.wo.RelyContentHelper.getInstance().Read(value, iprot);
						
						structs.SetRely_content(value);
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
		
		
		public void Write(WorkOrderProcessResult structs, Protocol oprot){
			
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
			
			
			if(structs.GetRely_content() != null) {
				
				oprot.WriteFieldBegin("rely_content");
				
				com.vip.vop.logistics.wo.RelyContentHelper.getInstance().Write(structs.GetRely_content(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rely_content can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WorkOrderProcessResult bean){
			
			
		}
		
	}
	
}