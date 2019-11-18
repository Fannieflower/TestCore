using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.product{
	
	
	
	public class SkuPriceHelper : TBeanSerializer<SkuPrice>
	{
		
		public static SkuPriceHelper OBJ = new SkuPriceHelper();
		
		public static SkuPriceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SkuPrice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("foorPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFoorPrice(value);
					}
					
					
					
					
					
					if ("retailPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetRetailPrice(value);
					}
					
					
					
					
					
					if ("specialFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetSpecialFrom(value);
					}
					
					
					
					
					
					if ("specialTo".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetSpecialTo(value);
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
		
		
		public void Write(SkuPrice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteString(structs.GetPartnerId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("partnerId can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteDouble((double)structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFoorPrice() != null) {
				
				oprot.WriteFieldBegin("foorPrice");
				oprot.WriteDouble((double)structs.GetFoorPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRetailPrice() != null) {
				
				oprot.WriteFieldBegin("retailPrice");
				oprot.WriteDouble((double)structs.GetRetailPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialFrom() != null) {
				
				oprot.WriteFieldBegin("specialFrom");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSpecialFrom())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialTo() != null) {
				
				oprot.WriteFieldBegin("specialTo");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetSpecialTo())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SkuPrice bean){
			
			
		}
		
	}
	
}