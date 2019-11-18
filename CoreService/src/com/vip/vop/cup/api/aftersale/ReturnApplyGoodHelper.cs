using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class ReturnApplyGoodHelper : TBeanSerializer<ReturnApplyGood>
	{
		
		public static ReturnApplyGoodHelper OBJ = new ReturnApplyGoodHelper();
		
		public static ReturnApplyGoodHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ReturnApplyGood structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("prod_sku_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProd_sku_id(value);
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
		
		
		public void Write(ReturnApplyGood structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProd_sku_id() != null) {
				
				oprot.WriteFieldBegin("prod_sku_id");
				oprot.WriteString(structs.GetProd_sku_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("prod_sku_id can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ReturnApplyGood bean){
			
			
		}
		
	}
	
}