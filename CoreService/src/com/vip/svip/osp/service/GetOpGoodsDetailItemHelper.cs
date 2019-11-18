using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetOpGoodsDetailItemHelper : TBeanSerializer<GetOpGoodsDetailItem>
	{
		
		public static GetOpGoodsDetailItemHelper OBJ = new GetOpGoodsDetailItemHelper();
		
		public static GetOpGoodsDetailItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOpGoodsDetailItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("salesNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesNo(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
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
					
					
					
					
					
					if ("price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrice(value);
					}
					
					
					
					
					
					if ("vipPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipPrice(value);
					}
					
					
					
					
					
					if ("multiSkuSamePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetMultiSkuSamePrice(value);
					}
					
					
					
					
					
					if ("saleState".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSaleState(value);
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
		
		
		public void Write(GetOpGoodsDetailItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSalesNo() != null) {
				
				oprot.WriteFieldBegin("salesNo");
				oprot.WriteString(structs.GetSalesNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
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
			
			
			if(structs.GetPrice() != null) {
				
				oprot.WriteFieldBegin("price");
				oprot.WriteString(structs.GetPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPrice() != null) {
				
				oprot.WriteFieldBegin("vipPrice");
				oprot.WriteString(structs.GetVipPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMultiSkuSamePrice() != null) {
				
				oprot.WriteFieldBegin("multiSkuSamePrice");
				oprot.WriteBool((bool)structs.GetMultiSkuSamePrice());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("multiSkuSamePrice can not be null!");
			}
			
			
			if(structs.GetSaleState() != null) {
				
				oprot.WriteFieldBegin("saleState");
				oprot.WriteI32((int)structs.GetSaleState()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("saleState can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOpGoodsDetailItem bean){
			
			
		}
		
	}
	
}