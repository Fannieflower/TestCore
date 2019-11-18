using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipGoodsBPInfoHelper : TBeanSerializer<SvipGoodsBPInfo>
	{
		
		public static SvipGoodsBPInfoHelper OBJ = new SvipGoodsBPInfoHelper();
		
		public static SvipGoodsBPInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipGoodsBPInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("goodsName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsName(value);
					}
					
					
					
					
					
					if ("imgUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetImgUrl(value);
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
					
					
					
					
					
					if ("diff".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiff(value);
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
		
		
		public void Write(SvipGoodsBPInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsName() != null) {
				
				oprot.WriteFieldBegin("goodsName");
				oprot.WriteString(structs.GetGoodsName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImgUrl() != null) {
				
				oprot.WriteFieldBegin("imgUrl");
				oprot.WriteString(structs.GetImgUrl());
				
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
			
			
			if(structs.GetDiff() != null) {
				
				oprot.WriteFieldBegin("diff");
				oprot.WriteString(structs.GetDiff());
				
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
		
		
		public void Validate(SvipGoodsBPInfo bean){
			
			
		}
		
	}
	
}