using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BrandGoodsPriceItemHelper : TBeanSerializer<BrandGoodsPriceItem>
	{
		
		public static BrandGoodsPriceItemHelper OBJ = new BrandGoodsPriceItemHelper();
		
		public static BrandGoodsPriceItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BrandGoodsPriceItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
					}
					
					
					
					
					
					if ("vipPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipPrice(value);
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
		
		
		public void Write(BrandGoodsPriceItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPrice() != null) {
				
				oprot.WriteFieldBegin("vipPrice");
				oprot.WriteString(structs.GetVipPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BrandGoodsPriceItem bean){
			
			
		}
		
	}
	
}