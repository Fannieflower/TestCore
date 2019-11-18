using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.jingdong{
	
	
	
	public class SkuOnShelfResponseHelper : TBeanSerializer<SkuOnShelfResponse>
	{
		
		public static SkuOnShelfResponseHelper OBJ = new SkuOnShelfResponseHelper();
		
		public static SkuOnShelfResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SkuOnShelfResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("op_result".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetOp_result(value);
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
		
		
		public void Write(SkuOnShelfResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOp_result() != null) {
				
				oprot.WriteFieldBegin("op_result");
				oprot.WriteBool((bool)structs.GetOp_result());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SkuOnShelfResponse bean){
			
			
		}
		
	}
	
}