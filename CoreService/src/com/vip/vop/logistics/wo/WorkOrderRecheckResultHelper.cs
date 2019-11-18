using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class WorkOrderRecheckResultHelper : TBeanSerializer<WorkOrderRecheckResult>
	{
		
		public static WorkOrderRecheckResultHelper OBJ = new WorkOrderRecheckResultHelper();
		
		public static WorkOrderRecheckResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WorkOrderRecheckResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("reckeck_reply_content".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.wo.RecheckRelyContent value;
						
						value = new com.vip.vop.logistics.wo.RecheckRelyContent();
						com.vip.vop.logistics.wo.RecheckRelyContentHelper.getInstance().Read(value, iprot);
						
						structs.SetReckeck_reply_content(value);
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
		
		
		public void Write(WorkOrderRecheckResult structs, Protocol oprot){
			
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
			
			
			if(structs.GetReckeck_reply_content() != null) {
				
				oprot.WriteFieldBegin("reckeck_reply_content");
				
				com.vip.vop.logistics.wo.RecheckRelyContentHelper.getInstance().Write(structs.GetReckeck_reply_content(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("reckeck_reply_content can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WorkOrderRecheckResult bean){
			
			
		}
		
	}
	
}