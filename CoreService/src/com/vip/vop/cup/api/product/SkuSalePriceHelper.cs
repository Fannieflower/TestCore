using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class SkuSalePriceHelper : TBeanSerializer<SkuSalePrice>
	{
		
		public static SkuSalePriceHelper OBJ = new SkuSalePriceHelper();
		
		public static SkuSalePriceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SkuSalePrice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("distribution_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistribution_price(value);
					}
					
					
					
					
					
					if ("suggest_retail_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSuggest_retail_price(value);
					}
					
					
					
					
					
					if ("market_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMarket_price(value);
					}
					
					
					
					
					
					if ("effective_start_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEffective_start_time(value);
					}
					
					
					
					
					
					if ("effective_end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEffective_end_time(value);
					}
					
					
					
					
					
					if ("price_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPrice_time(value);
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
		
		
		public void Write(SkuSalePrice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDistribution_price() != null) {
				
				oprot.WriteFieldBegin("distribution_price");
				oprot.WriteString(structs.GetDistribution_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuggest_retail_price() != null) {
				
				oprot.WriteFieldBegin("suggest_retail_price");
				oprot.WriteString(structs.GetSuggest_retail_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarket_price() != null) {
				
				oprot.WriteFieldBegin("market_price");
				oprot.WriteString(structs.GetMarket_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEffective_start_time() != null) {
				
				oprot.WriteFieldBegin("effective_start_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEffective_start_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEffective_end_time() != null) {
				
				oprot.WriteFieldBegin("effective_end_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEffective_end_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrice_time() != null) {
				
				oprot.WriteFieldBegin("price_time");
				oprot.WriteI64((long)structs.GetPrice_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SkuSalePrice bean){
			
			
		}
		
	}
	
}