using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipGoodsDetailItemHelper : TBeanSerializer<SvipGoodsDetailItem>
	{
		
		public static SvipGoodsDetailItemHelper OBJ = new SvipGoodsDetailItemHelper();
		
		public static SvipGoodsDetailItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipGoodsDetailItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("brandLogo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandLogo(value);
					}
					
					
					
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
					}
					
					
					
					
					
					if ("goodsName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsName(value);
					}
					
					
					
					
					
					if ("goodsImg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsImg(value);
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
					
					
					
					
					
					if ("skuMultiPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetSkuMultiPrice(value);
					}
					
					
					
					
					
					if ("multiBrand".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetMultiBrand(value);
					}
					
					
					
					
					
					if ("salesState".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSalesState(value);
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
		
		
		public void Write(SvipGoodsDetailItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandLogo() != null) {
				
				oprot.WriteFieldBegin("brandLogo");
				oprot.WriteString(structs.GetBrandLogo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsName() != null) {
				
				oprot.WriteFieldBegin("goodsName");
				oprot.WriteString(structs.GetGoodsName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsImg() != null) {
				
				oprot.WriteFieldBegin("goodsImg");
				oprot.WriteString(structs.GetGoodsImg());
				
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
			
			
			if(structs.GetSkuMultiPrice() != null) {
				
				oprot.WriteFieldBegin("skuMultiPrice");
				oprot.WriteBool((bool)structs.GetSkuMultiPrice());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("skuMultiPrice can not be null!");
			}
			
			
			if(structs.GetMultiBrand() != null) {
				
				oprot.WriteFieldBegin("multiBrand");
				oprot.WriteBool((bool)structs.GetMultiBrand());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("multiBrand can not be null!");
			}
			
			
			if(structs.GetSalesState() != null) {
				
				oprot.WriteFieldBegin("salesState");
				oprot.WriteI32((int)structs.GetSalesState()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("salesState can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipGoodsDetailItem bean){
			
			
		}
		
	}
	
}