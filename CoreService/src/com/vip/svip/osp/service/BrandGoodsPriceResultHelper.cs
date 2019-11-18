using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BrandGoodsPriceResultHelper : TBeanSerializer<BrandGoodsPriceResult>
	{
		
		public static BrandGoodsPriceResultHelper OBJ = new BrandGoodsPriceResultHelper();
		
		public static BrandGoodsPriceResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BrandGoodsPriceResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("itemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.BrandGoodsPriceItem> value;
						
						value = new List<com.vip.svip.osp.service.BrandGoodsPriceItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.BrandGoodsPriceItem elem1;
								
								elem1 = new com.vip.svip.osp.service.BrandGoodsPriceItem();
								com.vip.svip.osp.service.BrandGoodsPriceItemHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItemList(value);
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
		
		
		public void Write(BrandGoodsPriceResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItemList() != null) {
				
				oprot.WriteFieldBegin("itemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.BrandGoodsPriceItem _item0 in structs.GetItemList()){
					
					
					com.vip.svip.osp.service.BrandGoodsPriceItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BrandGoodsPriceResult bean){
			
			
		}
		
	}
	
}