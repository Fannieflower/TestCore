using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class BrandGoodsHelper : TBeanSerializer<BrandGoods>
	{
		
		public static BrandGoodsHelper OBJ = new BrandGoodsHelper();
		
		public static BrandGoodsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BrandGoods structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("totalGoodsValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalGoodsValue(value);
					}
					
					
					
					
					
					if ("vipBearValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVipBearValue(value);
					}
					
					
					
					
					
					if ("vendorBearValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorBearValue(value);
					}
					
					
					
					
					
					if ("memo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMemo(value);
					}
					
					
					
					
					
					if ("brandDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBrandDeduction(value);
					}
					
					
					
					
					
					if ("newDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetNewDeduction(value);
					}
					
					
					
					
					
					if ("vipScaleValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetVipScaleValue(value);
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
		
		
		public void Write(BrandGoods structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalGoodsValue() != null) {
				
				oprot.WriteFieldBegin("totalGoodsValue");
				oprot.WriteI32((int)structs.GetTotalGoodsValue()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipBearValue() != null) {
				
				oprot.WriteFieldBegin("vipBearValue");
				oprot.WriteI32((int)structs.GetVipBearValue()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorBearValue() != null) {
				
				oprot.WriteFieldBegin("vendorBearValue");
				oprot.WriteI32((int)structs.GetVendorBearValue()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMemo() != null) {
				
				oprot.WriteFieldBegin("memo");
				oprot.WriteString(structs.GetMemo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandDeduction() != null) {
				
				oprot.WriteFieldBegin("brandDeduction");
				oprot.WriteByte((byte)structs.GetBrandDeduction()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNewDeduction() != null) {
				
				oprot.WriteFieldBegin("newDeduction");
				oprot.WriteByte((byte)structs.GetNewDeduction()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipScaleValue() != null) {
				
				oprot.WriteFieldBegin("vipScaleValue");
				oprot.WriteDouble((double)structs.GetVipScaleValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BrandGoods bean){
			
			
		}
		
	}
	
}