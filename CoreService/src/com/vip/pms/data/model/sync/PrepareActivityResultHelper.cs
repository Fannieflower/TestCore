using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class PrepareActivityResultHelper : TBeanSerializer<PrepareActivityResult>
	{
		
		public static PrepareActivityResultHelper OBJ = new PrepareActivityResultHelper();
		
		public static PrepareActivityResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PrepareActivityResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("promotionObjectId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetPromotionObjectId(value);
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
		
		
		public void Write(PrepareActivityResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPromotionObjectId() != null) {
				
				oprot.WriteFieldBegin("promotionObjectId");
				oprot.WriteI64((long)structs.GetPromotionObjectId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("promotionObjectId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PrepareActivityResult bean){
			
			
		}
		
	}
	
}