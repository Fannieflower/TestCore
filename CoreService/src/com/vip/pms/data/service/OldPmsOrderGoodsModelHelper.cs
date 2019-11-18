using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OldPmsOrderGoodsModelHelper : TBeanSerializer<OldPmsOrderGoodsModel>
	{
		
		public static OldPmsOrderGoodsModelHelper OBJ = new OldPmsOrderGoodsModelHelper();
		
		public static OldPmsOrderGoodsModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OldPmsOrderGoodsModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("sizeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSizeId(value);
					}
					
					
					
					
					
					if ("amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetAmount(value);
					}
					
					
					
					
					
					if ("fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFav(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("refId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefId(value);
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
		
		
		public void Write(OldPmsOrderGoodsModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetSizeId() != null) {
				
				oprot.WriteFieldBegin("sizeId");
				oprot.WriteString(structs.GetSizeId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sizeId can not be null!");
			}
			
			
			if(structs.GetAmount() != null) {
				
				oprot.WriteFieldBegin("amount");
				oprot.WriteI32((int)structs.GetAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("amount can not be null!");
			}
			
			
			if(structs.GetFav() != null) {
				
				oprot.WriteFieldBegin("fav");
				oprot.WriteDouble((double)structs.GetFav());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteDouble((double)structs.GetTotal());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefId() != null) {
				
				oprot.WriteFieldBegin("refId");
				oprot.WriteString(structs.GetRefId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OldPmsOrderGoodsModel bean){
			
			
		}
		
	}
	
}