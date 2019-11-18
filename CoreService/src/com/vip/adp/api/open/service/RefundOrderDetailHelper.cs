using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class RefundOrderDetailHelper : TBeanSerializer<RefundOrderDetail>
	{
		
		public static RefundOrderDetailHelper OBJ = new RefundOrderDetailHelper();
		
		public static RefundOrderDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefundOrderDetail structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("goodsPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsPrice(value);
					}
					
					
					
					
					
					if ("goodsCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsCount(value);
					}
					
					
					
					
					
					if ("commission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission(value);
					}
					
					
					
					
					
					if ("totalCost".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTotalCost(value);
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
		
		
		public void Write(RefundOrderDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSizeId() != null) {
				
				oprot.WriteFieldBegin("sizeId");
				oprot.WriteString(structs.GetSizeId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsPrice() != null) {
				
				oprot.WriteFieldBegin("goodsPrice");
				oprot.WriteString(structs.GetGoodsPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsCount() != null) {
				
				oprot.WriteFieldBegin("goodsCount");
				oprot.WriteI32((int)structs.GetGoodsCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommission() != null) {
				
				oprot.WriteFieldBegin("commission");
				oprot.WriteString(structs.GetCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalCost() != null) {
				
				oprot.WriteFieldBegin("totalCost");
				oprot.WriteString(structs.GetTotalCost());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefundOrderDetail bean){
			
			
		}
		
	}
	
}