using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class TaxOrderResponeHelper : TBeanSerializer<TaxOrderRespone>
	{
		
		public static TaxOrderResponeHelper OBJ = new TaxOrderResponeHelper();
		
		public static TaxOrderResponeHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TaxOrderRespone structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("taxOrderHeader".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vpos.service.TaxOrderHeader value;
						
						value = new com.vip.fcs.vpos.service.TaxOrderHeader();
						com.vip.fcs.vpos.service.TaxOrderHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetTaxOrderHeader(value);
					}
					
					
					
					
					
					if ("orderItemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.fcs.vpos.service.TaxOrderItem> value;
						
						value = new List<com.vip.fcs.vpos.service.TaxOrderItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.fcs.vpos.service.TaxOrderItem elem1;
								
								elem1 = new com.vip.fcs.vpos.service.TaxOrderItem();
								com.vip.fcs.vpos.service.TaxOrderItemHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderItemList(value);
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
		
		
		public void Write(TaxOrderRespone structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTaxOrderHeader() != null) {
				
				oprot.WriteFieldBegin("taxOrderHeader");
				
				com.vip.fcs.vpos.service.TaxOrderHeaderHelper.getInstance().Write(structs.GetTaxOrderHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderItemList() != null) {
				
				oprot.WriteFieldBegin("orderItemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.fcs.vpos.service.TaxOrderItem _item0 in structs.GetOrderItemList()){
					
					
					com.vip.fcs.vpos.service.TaxOrderItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TaxOrderRespone bean){
			
			
		}
		
	}
	
}