using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PromotionOrderGoodsModelHelper : TBeanSerializer<PromotionOrderGoodsModel>
	{
		
		public static PromotionOrderGoodsModelHelper OBJ = new PromotionOrderGoodsModelHelper();
		
		public static PromotionOrderGoodsModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PromotionOrderGoodsModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("goodsNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsNumber(value);
					}
					
					
					
					
					
					if ("favAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFavAmount(value);
					}
					
					
					
					
					
					if ("totalFavAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotalFavAmount(value);
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
		
		
		public void Write(PromotionOrderGoodsModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsId can not be null!");
			}
			
			
			if(structs.GetGoodsNumber() != null) {
				
				oprot.WriteFieldBegin("goodsNumber");
				oprot.WriteI32((int)structs.GetGoodsNumber()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsNumber can not be null!");
			}
			
			
			if(structs.GetFavAmount() != null) {
				
				oprot.WriteFieldBegin("favAmount");
				oprot.WriteDouble((double)structs.GetFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalFavAmount() != null) {
				
				oprot.WriteFieldBegin("totalFavAmount");
				oprot.WriteDouble((double)structs.GetTotalFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PromotionOrderGoodsModel bean){
			
			
		}
		
	}
	
}