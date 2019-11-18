using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class CreateWorkOrderRespHelper : TBeanSerializer<CreateWorkOrderResp>
	{
		
		public static CreateWorkOrderRespHelper OBJ = new CreateWorkOrderRespHelper();
		
		public static CreateWorkOrderRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateWorkOrderResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
		
		
		public void Write(CreateWorkOrderResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWork_order_no() != null) {
				
				oprot.WriteFieldBegin("work_order_no");
				oprot.WriteString(structs.GetWork_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateWorkOrderResp bean){
			
			
		}
		
	}
	
}