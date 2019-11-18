using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetTheTimeSvipPriceResultHelper : TBeanSerializer<GetTheTimeSvipPriceResult>
	{
		
		public static GetTheTimeSvipPriceResultHelper OBJ = new GetTheTimeSvipPriceResultHelper();
		
		public static GetTheTimeSvipPriceResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetTheTimeSvipPriceResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("detailList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.PriceItem> value;
						
						value = new List<com.vip.svip.osp.service.PriceItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.PriceItem elem0;
								
								elem0 = new com.vip.svip.osp.service.PriceItem();
								com.vip.svip.osp.service.PriceItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetailList(value);
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
		
		
		public void Write(GetTheTimeSvipPriceResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDetailList() != null) {
				
				oprot.WriteFieldBegin("detailList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.PriceItem _item0 in structs.GetDetailList()){
					
					
					com.vip.svip.osp.service.PriceItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetTheTimeSvipPriceResult bean){
			
			
		}
		
	}
	
}