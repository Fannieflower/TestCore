using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class PriceItemHelper : TBeanSerializer<PriceItem>
	{
		
		public static PriceItemHelper OBJ = new PriceItemHelper();
		
		public static PriceItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PriceItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMid(value);
					}
					
					
					
					
					
					if ("vipPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipPrice(value);
					}
					
					
					
					
					
					if ("svipPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSvipPrice(value);
					}
					
					
					
					
					
					if ("skuMultiplePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetSkuMultiplePrice(value);
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
		
		
		public void Write(PriceItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMid() != null) {
				
				oprot.WriteFieldBegin("mid");
				oprot.WriteString(structs.GetMid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPrice() != null) {
				
				oprot.WriteFieldBegin("vipPrice");
				oprot.WriteString(structs.GetVipPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSvipPrice() != null) {
				
				oprot.WriteFieldBegin("svipPrice");
				oprot.WriteString(structs.GetSvipPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuMultiplePrice() != null) {
				
				oprot.WriteFieldBegin("skuMultiplePrice");
				oprot.WriteBool((bool)structs.GetSkuMultiplePrice());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("skuMultiplePrice can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PriceItem bean){
			
			
		}
		
	}
	
}