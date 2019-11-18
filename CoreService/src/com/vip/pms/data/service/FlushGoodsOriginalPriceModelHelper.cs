using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class FlushGoodsOriginalPriceModelHelper : TBeanSerializer<FlushGoodsOriginalPriceModel>
	{
		
		public static FlushGoodsOriginalPriceModelHelper OBJ = new FlushGoodsOriginalPriceModelHelper();
		
		public static FlushGoodsOriginalPriceModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FlushGoodsOriginalPriceModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("spuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpuId(value);
					}
					
					
					
					
					
					if ("originalPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalPrice(value);
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
		
		
		public void Write(FlushGoodsOriginalPriceModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSpuId() != null) {
				
				oprot.WriteFieldBegin("spuId");
				oprot.WriteString(structs.GetSpuId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("spuId can not be null!");
			}
			
			
			if(structs.GetOriginalPrice() != null) {
				
				oprot.WriteFieldBegin("originalPrice");
				oprot.WriteString(structs.GetOriginalPrice());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("originalPrice can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FlushGoodsOriginalPriceModel bean){
			
			
		}
		
	}
	
}