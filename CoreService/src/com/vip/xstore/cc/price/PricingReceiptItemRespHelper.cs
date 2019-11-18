using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class PricingReceiptItemRespHelper : TBeanSerializer<PricingReceiptItemResp>
	{
		
		public static PricingReceiptItemRespHelper OBJ = new PricingReceiptItemRespHelper();
		
		public static PricingReceiptItemRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PricingReceiptItemResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("hasNext".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasNext(value);
					}
					
					
					
					
					
					if ("pricingReceiptItems".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.price.PricingReceiptItem> value;
						
						value = new List<com.vip.xstore.cc.price.PricingReceiptItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.price.PricingReceiptItem elem0;
								
								elem0 = new com.vip.xstore.cc.price.PricingReceiptItem();
								com.vip.xstore.cc.price.PricingReceiptItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPricingReceiptItems(value);
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
		
		
		public void Write(PricingReceiptItemResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHasNext() != null) {
				
				oprot.WriteFieldBegin("hasNext");
				oprot.WriteBool((bool)structs.GetHasNext());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasNext can not be null!");
			}
			
			
			if(structs.GetPricingReceiptItems() != null) {
				
				oprot.WriteFieldBegin("pricingReceiptItems");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.price.PricingReceiptItem _item0 in structs.GetPricingReceiptItems()){
					
					
					com.vip.xstore.cc.price.PricingReceiptItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PricingReceiptItemResp bean){
			
			
		}
		
	}
	
}