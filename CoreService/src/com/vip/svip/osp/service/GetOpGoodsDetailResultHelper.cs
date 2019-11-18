using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetOpGoodsDetailResultHelper : TBeanSerializer<GetOpGoodsDetailResult>
	{
		
		public static GetOpGoodsDetailResultHelper OBJ = new GetOpGoodsDetailResultHelper();
		
		public static GetOpGoodsDetailResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetOpGoodsDetailResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsDetailList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.GetOpGoodsDetailItem> value;
						
						value = new List<com.vip.svip.osp.service.GetOpGoodsDetailItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.GetOpGoodsDetailItem elem1;
								
								elem1 = new com.vip.svip.osp.service.GetOpGoodsDetailItem();
								com.vip.svip.osp.service.GetOpGoodsDetailItemHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsDetailList(value);
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
		
		
		public void Write(GetOpGoodsDetailResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsDetailList() != null) {
				
				oprot.WriteFieldBegin("goodsDetailList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.GetOpGoodsDetailItem _item0 in structs.GetGoodsDetailList()){
					
					
					com.vip.svip.osp.service.GetOpGoodsDetailItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetOpGoodsDetailResult bean){
			
			
		}
		
	}
	
}