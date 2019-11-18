using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActGoodsModelHelper : TBeanSerializer<PmsActGoodsModel>
	{
		
		public static PmsActGoodsModelHelper OBJ = new PmsActGoodsModelHelper();
		
		public static PmsActGoodsModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActGoodsModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mSizeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetMSizeId(value);
					}
					
					
					
					
					
					if ("arrivalPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetArrivalPrice(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("mid".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMid(value);
					}
					
					
					
					
					
					if ("vSkuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetVSkuId(value);
					}
					
					
					
					
					
					if ("totalQuota".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalQuota(value);
					}
					
					
					
					
					
					if ("fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFav(value);
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
		
		
		public void Write(PmsActGoodsModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMSizeId() != null) {
				
				oprot.WriteFieldBegin("mSizeId");
				oprot.WriteI64((long)structs.GetMSizeId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("mSizeId can not be null!");
			}
			
			
			if(structs.GetArrivalPrice() != null) {
				
				oprot.WriteFieldBegin("arrivalPrice");
				oprot.WriteDouble((double)structs.GetArrivalPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMid() != null) {
				
				oprot.WriteFieldBegin("mid");
				oprot.WriteI64((long)structs.GetMid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVSkuId() != null) {
				
				oprot.WriteFieldBegin("vSkuId");
				oprot.WriteI64((long)structs.GetVSkuId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalQuota() != null) {
				
				oprot.WriteFieldBegin("totalQuota");
				oprot.WriteI32((int)structs.GetTotalQuota()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFav() != null) {
				
				oprot.WriteFieldBegin("fav");
				oprot.WriteDouble((double)structs.GetFav());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActGoodsModel bean){
			
			
		}
		
	}
	
}